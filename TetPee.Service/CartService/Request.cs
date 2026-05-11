namespace TetPee.Service.CartService;

public class Request
{
    public class AddProductRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
    
    public class RemoveProductRequest
    {
        public Guid ProductId { get; set; }
    }
}