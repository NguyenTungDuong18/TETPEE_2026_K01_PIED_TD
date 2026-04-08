namespace TetPee.Service.Product;

public interface IService
{
    public Task<string> createProduct(Request.CreateProductRequest request);
}