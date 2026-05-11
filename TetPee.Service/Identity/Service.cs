using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TetPee.Repositoty;
using TetPee.Service.JwtService;

namespace TetPee.Service.Identity;

public class Service:IService
{
    
    private readonly JwtService.IServices _jwtService;
    
    private readonly AppDbContext _dbContext;
    
    private readonly JwtOptions _jwtOptions = new ();
    
    public Service( JwtService.IServices jwtService, AppDbContext dbContext, IConfiguration configuration)
    {
        _jwtService = jwtService;
        _dbContext = dbContext;
        configuration.GetSection(nameof(JwtService)).Bind(_jwtOptions);
    }

    public async Task<Response.IdentityResponse> Login(string email, string password)
    {
        var user = await _dbContext.Users.Include(x => x.Seller).FirstOrDefaultAsync(u => u.Email == email);

        if (user == null)
        {
            throw new NotImplementedException();
        }

        if (user.HashedPassword != password)
        {
            throw new Exception("Invalid password");
        }
        
        //User này chắc chắn là tôi
        var claims = new List<Claim>
        {
            new Claim("UserId", user.Id.ToString()),
            new Claim("Email", user.Email),
            new Claim("Role", user.Role),
            new Claim(ClaimTypes.Role, user.Role),
            //phải có claim này để phân quyền cho các API endpoint,nếu thiếu claim này thì sẽ không phân quyền được 
            new Claim(ClaimTypes.Expired, DateTimeOffset.UtcNow.AddMinutes(_jwtOptions.ExpireMinutes).ToString()),
        };

        if (user.Role == "Seller")
        {
            var seller = await _dbContext.Sellers.FirstOrDefaultAsync(s => s.UserId == user.Id);
            if (seller != null)
            {
                claims.Add(new Claim("SellerId", seller.Id.ToString()));
            }
        }
        
        var token = _jwtService.GenerateAccessToken(claims);

        var result = new Response.IdentityResponse()
        {
            AccessToken = token,
        };
        
        return result;
    }
}