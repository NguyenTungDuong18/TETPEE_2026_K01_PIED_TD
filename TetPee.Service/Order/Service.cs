using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Data;
using TetPee.Repository.Entity;

namespace TetPee.Service.Order;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    private readonly IHttpContextAccessor _httpContext;

    public Service(AppDbContext dbContext, IHttpContextAccessor httpContext)
    {
        _dbContext = dbContext;
        _httpContext = httpContext;
    }
    public async Task<Response.CreateOrderResponse> CreateOrder(Request.CreateOrderRequest request)
    {
        var userId = _httpContext.HttpContext!.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;
        var userIdGuid = Guid.Parse(userId!);
        
        // List Object -> List Guid => Mapping List thì xài select
        var productIds = request.Products.Select(x => x.ProductId).Distinct().ToList();// Này là id sp khách hàng gửi lên
        // request client gửi lên có productId và Quantity, select này chỉ lấy productId và dùng toList để gom thành danh sách guid
        
        // Phòng TH ng dùng truyền vô id product k có trong DB
        var  query = _dbContext.Products.Where(x=>productIds.Contains(x.Id));
        // chạy qua hết Db nếu Id product ng dùng truyền vào tồn tại và nằm trong bảng này thì lấy ra
        
        var productCount = await query.CountAsync();// so luong san pham tim thay
        
        if (productCount != productIds.Count)//neu so luong ton tai trong datb tim dc khac voi so luong truyen vao thi bao loi
        {
            throw new Exception("Some product not found");
        }
        
        var result = await query.ToListAsync();// list Id product tim duoc trong Db
        
        decimal totalAmount = 0;

        foreach (var prod in result)
        {
            var quantity = request.Products.First(x => x.ProductId == prod.Id).Quantity;
            // tìm sản phẩm có id product truyền vào = id trong list sản phẩm tìm dc trong DB

            if (quantity <= 0)
            {
                throw new Exception($"Quantity of product {prod.Id} must be greater than 0"); 
            }
            
            totalAmount += prod.Price * quantity;
        }

        if (totalAmount <= 0)
        {
            throw new Exception("Total  amount must be greater than 0");
        }
        
        var order = new Repository.Entity.Order
        {
            Id = Guid.NewGuid(),
            UserId = userIdGuid,
            TotalAmount = totalAmount,
            Address = request.Address,
            Status = "Pending",
            CreateAt = DateTime.UtcNow
        };
        _dbContext.Orders.Add(order);
        await _dbContext.SaveChangesAsync();

        List<OrderDetail> orderDetails = new List<OrderDetail>();

        foreach (var prod in result)
        {
            var quantity = request.Products.First(x => x.ProductId == prod.Id).Quantity;

            var orderDetail = new OrderDetail()
            {
                Id = Guid.NewGuid(),
                OrderId = order.Id,
                ProductId = prod.Id,
                Quantity = quantity,
                UnitPrice = prod.Price,
            };
            orderDetails.Add(orderDetail);
        }

        if (orderDetails.Any()) // Mang nay co it nhat 1 phan tu thi add vo Db
        {
              _dbContext.AddRange(orderDetails);
              await _dbContext.SaveChangesAsync();
        }

        string description = $"TETPEE - {order.Id}";
        
        var response = new Response.CreateOrderResponse()
        {
            OrderId = order.Id,
            TotalAmount = order.TotalAmount,
            BankName = "MBBank",
            BankAccount = "VQRQAIDXY6842",
            Description = $"Payment for order {order.Id}",
            QRcode = ""
        };
        
        string qrCode = $"https://qr.sepay.vn/img?acc={response.BankAccount}&" +
                        $"bank={response.BankName}&" +
                        $"amount={(int)totalAmount}&" +
                        $"des={description}&" +
                        $"template=gronly";
        
        response.QRcode = qrCode;        
        return response;
    }

    public async Task SepayWebhookHandler(Request.SepayWebhookRequest request)
    {
        var description = request.Code;
        
        var raw = description.Replace("TETPEE", "");
        
        Guid? orderId = null;

        if (raw.Length == 32)
        {
            var formatted = $"{raw.Substring(0, 8)}-" +
                            $"{raw.Substring(8, 4)}-" +
                            $"{raw.Substring(12, 4)}-" +
                            $"{raw.Substring(16, 4)}-" +
                            $"{raw.Substring(20, 12)}-";

            if (Guid.TryParse(formatted, out var guid))
            {
                orderId = guid;
            }
        }
        else
        {
            throw new Exception("Invalid description format");
        }

        if (orderId == null)
        {
            throw new Exception("OrderId not found in description");
        }
        
        var query = _dbContext.Orders.Where(x => 
                x.Id == orderId)
                .Include(x => x.OrderDetails);// dùng để join chứ k trả ra  như select
        
        var order = await query.FirstOrDefaultAsync();

        if (order == null)
        {
            throw new Exception("Order not found");
        }

        if (order.Status != "Pending")
        {
            throw new Exception("Order already processed");
        }

        if (order.TotalAmount != request.TransferAmount)
        {
            throw new Exception("Transfer amount not match");
        }
        
        order.Status = "Completed";
        _dbContext.Update(order);
        await _dbContext.SaveChangesAsync();
     
        var productIds = order.OrderDetails.Select(x => x.ProductId).ToList();
        
        // Tìm những sản phẩm chứa trong Cart với các id sau products của UserId
        // Tìm được roi thì xóa đi
        // _dbContext.RemoveRange();
        var  queryProductCart = _dbContext.CartDetails.Where(x=>
            x.Cart.UserId == order.UserId &&
            productIds.Contains(x.ProductId));
        var removeProduct = await queryProductCart.ToListAsync(); 
        
        _dbContext.CartDetails.RemoveRange(removeProduct);
        await _dbContext.SaveChangesAsync();
    }

    // Bản chất của SePay
    // Sẽ là 1 thằng ngồi lắng nghe tất cả các giao dịch của mình trong tài khoản
    // Và mình có thể làm 1 thứ, nếu có giao dịch nào chuyển đến thì gọi 1 api callback
    // Và không phải giao dịch nào cũng là giao dịch của hệ thống mình.
        // Giao dịch trả tiền nợ từ bạn a -> Call Api 
        // Giao dịch mua hàng từ hệ thống TetPee -> Call Api
        // Giao dịch trả tiền có tc -> Call Api
    
        // Call Api của ai thì tùy mn setup với hệ thống của mình, nhưng ở đây 
            // a muốn là nó call api của mình để thông báo là đã ck thành công
            
        // Không phải tất cả giao dịch nào cũng là giao dịch của hệ thống mình, vậy thì để
            // phân biệt giao dịch của mình, thì chúng ta sẽ tạo ra 1 dấu ấn riêng, làm dấu
    
    
}