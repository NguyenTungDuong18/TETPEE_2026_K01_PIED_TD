namespace TetPee.Service.Order;

public class Request
{
    public class CreateOrderRequest
    {
        public string Address { get; set; }
        
        public List<ProductOrderRequest> Products { get; set; }
    }
    
    public class ProductOrderRequest
    {
        public Guid ProductId { get; set; }
        
        public int Quantity { get; set; }
    }
    
    //tạo đơn hàng (Giả sử hệ thống muốn đặt hàng thì phải chuyển khoản trước )
    //Setup chuyển khoản thành công bằng tiền thật để xác nhận đơn hàng đã đc đặt
    //Nếu tạo ra đơn hàng mà không chuyển khoản liền thì sẽ bị hủy sau 15', để tránh tình trạng đặt hàng rồi
    //không chuyển khoản ảnh hưởng đến việc quản lí đơn hàng
       
       
    //Quản lí đơn hàng
    //Cập nhật đơn hàng
    
    public class SepayWebhookRequest
    {
       public string Gateway { get; set; }
       public string TransactionDate { get; set; }
       public string AccountNumber { get; set; }
       public string SubAccountNumber { get; set; }
       public string Code { get; set; }
       public string Content { get; set; }
       public string TransferType { get; set; }
       public string Description { get; set; }
       public decimal TransferAmount { get; set; }
       public string ReferenceCode { get; set; }
       public string Accumulated { get; set; }
       public long Id { get; set; }
    }
    
    
}