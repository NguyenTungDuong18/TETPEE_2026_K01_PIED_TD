using System.Security.AccessControl;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;
using TetPee.Repositoty;

namespace TetPee.Service.Order;

public class Service : IService
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
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;

        var userIdGuid = Guid.Parse(userId!);

        //List Obj ==> List Guid  (Mapping List thì xài select)

        var productIds = request.Products.Select(x => x.ProductId).Distinct().ToList();

        var query = _dbContext.Products.Where(x => productIds.Contains(x.Id));

        var productCount = await query.CountAsync();

        if (productCount != productIds.Count)
        {
            throw new Exception("Some products are not identical");
        }

        var result = await query.ToListAsync();

        decimal totalAmount = 0;
        foreach (var product in result)
        {
            //Tìm trong list giỏ sảng sản phẩm để tìm số lượng mà khách hàng muốn mua !
            var quantity = request.Products.First(x => x.ProductId == product.Id).Quantity;

            if (quantity <= 0)
            {
                throw new Exception("Quantity must be greater than 0");
            }
            
            totalAmount += product.Price * quantity;
        }

        if (totalAmount <= 0)
        {
            throw new Exception("total amount must be greater than 0");
        }

        var order = new Repository.Entity.Order()
        {
            Id = Guid.NewGuid(),
            UserId = userIdGuid,
            TotalAmount = totalAmount,
            Address = request.Address,
            Status = "Pending",
            CreatedAt = DateTime.UtcNow,
        };

        _dbContext.Orders.Add(order);
        await _dbContext.SaveChangesAsync();

        List<OrderDetail> orderDetails = new List<OrderDetail>();
        foreach (var product in result)
        {
            var quantity = request.Products.First(x => x.ProductId == product.Id).Quantity;

            var orderDetail = new OrderDetail()
            {
                Id = Guid.NewGuid(),
                ProductId = product.Id,
                Quantity = quantity,
                OrderId = order.Id,
                UnitPrice = product.Price,
                CreatedAt = DateTime.UtcNow,
            };

            orderDetails.Add(orderDetail);
        }

        if (orderDetails.Any())
        {
            _dbContext.OrderDetails.AddRange(orderDetails);
            await _dbContext.SaveChangesAsync();
        }

        
        string description = $"TETPEE-{order.Id}";
      
        
        var response = new Response.CreateOrderResponse()
        {
            OrderId = order.Id,
            TotalAmount = order.TotalAmount,
            BankName = "VietinBank",
            BankAccount = "103879188653",
            Description = description,
            QRCode = ""
        };
        
        string sqCode = $"https://qr.sepay.vn/img?bank={response.BankName}&" +
                        $"acc={response.BankAccount}&" +
                        $"template=compact&" +
                        $"amount={response.TotalAmount}&" +
                        $"des={response.Description}&";
        
        response.QRCode = sqCode;
        
        return response;
    }

    public async Task SepayWebhookHandler(Request.SepayWebhookRequest request)
    {
        var description = request.Code;
        
        var raw = description.Replace("TETPEE", "");

        Guid? orderId = null;
        
        if (raw.Length == 32)
            //Mặc định 1 Guid sẽ có 32 ký tự nếu không có dấu gạch nối
            // còn nếu có dấu gạch nối thì sẽ có 36 ký tự
        {
            //vì OrderID theo format là không có dấu gạch ngang
            var formatted = $"{raw.Substring(0, 8)}-" +
                            $"{raw.Substring(8, 4)}-" +
                            $"{raw.Substring(12, 4)}-" +
                            $"{raw.Substring(16, 4)}-" +
                            $"{raw.Substring(20, 12)}";
            //hành động trên là lấy chuỗi ra và thêm dấu rạch ngang vào 
            if (Guid.TryParse(formatted, out var guid))
            {
                orderId = guid;
            }
        } else
        {
            throw new Exception("Invalid description format");
        }
        
        var query = _dbContext.Orders.Where(x => x.Id == orderId);
        
        var order = await query.FirstOrDefaultAsync();

        if (order == null)
        {
            throw new Exception("Order not found");
        }

        if (order.Status == "Pending")
        {
            throw new Exception("order already processed");
        }

        if (order.TotalAmount != request.TransferAmount)
        {
            throw new Exception("Invalid transfer amount");
        }
        
        order.Status = "Completed";
        
        _dbContext.Orders.Update(order);
        await _dbContext.SaveChangesAsync();
    }
}

//Bản chất của Sepay
// Sẽ 1 thg ngồi lắng nghe hết tất cả các giao dịch của mình trong tài khoản
// và mình sẽ có thể làm 1 thứ, nếu có giao dịch nào chuyển đến thì gọi 1 api callback
// và không phải giao dịch nào cũng là giao dịch của hệ thống mình
     //Giao dịch trả tiền lại từ bạn A -> call API
     //Giao dịch mua hàng từ hệ thống Tetpee -> call API
     //Giao dịch trả tiền cổ tức -> call API
     
     //Call API của ai tùy mọi người setup với hệ thống của mình, nhưng ở đây
     // a muốn là nó call api của mình để thông báo là đã chuyển khoản thành công
     
     //không phải giao dịch nào cũng thuộc về hệ thống của mình vậy thì để phân biệt giao dịch của mình thì chúng ta
     //sẽ tạo ra 1 dấu ấn riêng (làm dấu)