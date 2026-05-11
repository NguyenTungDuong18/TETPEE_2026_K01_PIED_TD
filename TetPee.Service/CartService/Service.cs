using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;
using TetPee.Repositoty;
using TetPee.Repositoty.Entity;

namespace TetPee.Service.CartService;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IHttpContextAccessor _httpContext;

    public Service(AppDbContext dbContext, IHttpContextAccessor httpContext)
    {
        _dbContext = dbContext;
        _httpContext = httpContext;
    }

    public async Task CreateCart()
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;

        var userIdGuid = Guid.Parse(userId!);

        var query = _dbContext.Carts.Where(x => x.UserId == userIdGuid);

        var isExist = await query.AnyAsync();

        if (isExist)
        {
            throw new Exception("Cart already exist");
        }

        var cart = new Cart()
        {
            UserId = userIdGuid,
        };

        _dbContext.Carts.Add(cart);

        await _dbContext.SaveChangesAsync();
    }

    public async Task AddProductToCart(Request.AddProductRequest request)
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;

        var userIdGuid = Guid.Parse(userId!);

        var query = _dbContext.Carts.Where(x => x.UserId == userIdGuid);

        var cart = await query.FirstOrDefaultAsync();

        if (cart == null)
        {
            cart = new Cart()
            {
                UserId = userIdGuid,
                Id = Guid.NewGuid(),
            };

            _dbContext.Carts.Add(cart);
            await _dbContext.SaveChangesAsync();
        }

        var productQuery = _dbContext.CartDetails.Where(x => x.CartId == cart.Id && x.ProductId == request.ProductId);

        var cartExist = await productQuery.FirstOrDefaultAsync();


        if (cartExist != null)
        {
            cartExist.Quantity += request.Quantity;
            _dbContext.CartDetails.Update(cartExist);
            await _dbContext.SaveChangesAsync();
            return;
        }
        
        var cartDetail = new CartDetail()
        {
            ProductId = request.ProductId,
            CartId = cart.Id,
            Quantity = request.Quantity,
        };

        _dbContext.CartDetails.Add(cartDetail);
        await _dbContext.SaveChangesAsync();
    }

    public async Task RemoveProductFromCart(Request.RemoveProductRequest request)
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;

        var userIdGuid = Guid.Parse(userId!);

        var query = await _dbContext.CartDetails.FirstOrDefaultAsync(x =>
            x.CartId == userIdGuid && x.ProductId == request.ProductId);


        if (query == null)
        {
            throw new Exception("Product does not exist");
        }

        _dbContext.CartDetails.Remove(query);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Response.ProductResponse>> GetCart()
    {
        var userId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId")?.Value;

        var userIdGuid = Guid.Parse(userId!);
        
        var query =  _dbContext.CartDetails.Where(x =>
            x.Cart.UserId == userIdGuid).Select(x => new Response.ProductResponse()
        {
            Name = x.Product.Name,
            Price =  x.Product.Price,
            Url =  x.Product.UrlImage,
            Quantity = x.Quantity,
        });

        var result = await query.ToListAsync();
        return result;
    }
}