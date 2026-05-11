using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Data;
using TetPee.Repository.Entity;

namespace TetPee.Service.Product;

public class Service:IService
{
    private readonly AppDbContext _dbContext;
    private readonly IHttpContextAccessor _httpContext;//lấy được các claims trong token
    
    public Service(AppDbContext dbContext,  IHttpContextAccessor httpContext)
    {
        _dbContext = dbContext;
        _httpContext = httpContext;
    }
    public async Task<string> CreateProduct(Request.CreateProductRequest request)
    {
        var sellerId = _httpContext.HttpContext.User.Claims.FirstOrDefault(x=> x.Type == "SellerId")?.Value;
        var sellerIdGuid = Guid.Parse(sellerId!);
        
        var existingProductQuery =
            _dbContext.Products.Where(x => x.Name.ToLower().Trim() == request.Name.ToLower().Trim());

        bool isExistProducct = await existingProductQuery.AnyAsync();// AnyAsync trả ra yes/no
        
        if (isExistProducct)
            throw new Exception("Product with the same name already exists");

        var existingSellerQuery = _dbContext.Sellers.Where(x => x.Id == sellerIdGuid);
        
        bool isExistSeller = await existingSellerQuery.AnyAsync();

        if (!isExistSeller)
        {
            throw new Exception("Seller not exist");
        }

        var product = new Repository.Entity.Product
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            SellerId = sellerIdGuid
        };
        _dbContext.Products.Add(product);
        var sellerResult = await _dbContext.SaveChangesAsync();

        if (request.CategoryIds != null && request.CategoryIds.Count > 0)
        {
            var productCateList = request.CategoryIds.Select(id => new ProductCategory()
            {
                CategoryId = id,
                ProductId = product.Id
            });
            
            //Same with above but using foreach loop
            // var productCateList1 = new List<ProductCategory>();
            // foreach (var id in request.CategoryIds)
            // {
            //     var productCategory = new ProductCategory()
            //     {
            //         CategoryId = id,
            //         ProductId = product.Id
            //     };
            //     productCateList1.Add(productCategory);
            // }
            
            _dbContext.AddRange(productCateList);
            await _dbContext.SaveChangesAsync();
        }
        if(sellerResult > 0) return "Add Product successfully";
        return "Add Product failed";
    }
}
