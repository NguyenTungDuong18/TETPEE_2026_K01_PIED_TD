namespace TetPee.Service.CartService;

public interface IService
{
    public Task CreateCart();
       
       public Task AddProductToCart(Request.AddProductRequest request);
       
       public Task RemoveProductFromCart(Request.RemoveProductRequest request);
       
       public Task<List<Response.ProductResponse>> GetCart();
   

}
