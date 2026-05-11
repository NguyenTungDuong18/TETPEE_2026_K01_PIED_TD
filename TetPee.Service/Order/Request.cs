namespace TetPee.Service.Order;

public class Request
{
    public class CreateOrderRequest
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<ProductOrderRequest> Products { get; set; }
    }

    public class ProductOrderRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }

    
    //Tạo đơn hàng
        // Setup chuyển khoản thành công (bằng tiền thiệt), để xác nhận đơn hàng đã được đặt
        // Nếu tạo ra đơn hàng, mà không chuyển khoản liền , thì đơn hàng sẽ bị hủy sau 15p
            // để tránh tình trạng khách hàng đặt hàng rồi mà không chuyển khoản, làm ảnh hưởng đến việc quản lý đơn hàng 
    
    // Hủy đơn hàng
    // Cập nhật đơn hàng
    
    public class SepayWebhookRequest
    {
        public string Gateway { get; set; }
        public string TransactionDate { get; set; }
        public string AccountNumber { get; set; }
        public string subAccount { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public string TransferType { get; set; }
        public string Description { get; set; }
        public decimal TransferAmount { get; set; }
        public string ReferenceCode { get; set; }
        public string Accumulated { get; set; }
        public string Id { get; set; }
    }
}