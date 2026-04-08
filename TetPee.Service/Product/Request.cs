namespace TetPee.Service.Product;

public class Request
{
    public class CreateProductRequest
    {
        public required string name { get; set; }
        public required string description { get; set; }
        public required decimal price { get; set; }
        public List<Guid>? categoryIds { get; set; }
    }
}