using System.Security.Claims;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TetPee.Repository.Data;
using TetPee.Service.JwtService;

namespace TetPee.Service.Identity;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    private readonly JwtService.IJwtService _jwtService;
    private readonly JwtOptions _jwtOption = new();
    

    public Service(IConfiguration configuration,AppDbContext dbContext,  JwtService.IJwtService jwtService)
    {
        _dbContext = dbContext;
        _jwtService = jwtService;
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOption);
    }

    public async Task<Response.IdenetityResponse> Login(string email, string password)
    {
        var user = await _dbContext.Users
            .Include(x => x.Seller)
            .FirstOrDefaultAsync(u => u.Email == email);
        if (user == null)
        {
            throw new Exception("User not found");
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
            // Phải có claim này để phân quyền cho các API endpoint, nếu thiếu claim này thì không phân quyền được
            new Claim(ClaimTypes.Expiration, 
                DateTimeOffset.UtcNow.AddMinutes(_jwtOption.ExpireMinutes).ToString()),
        };

        if (user.Role == "Seller")
        {
            // var seller = await  _dbContext.Sellers.FirstOrDefaultAsync(u => u.UserId == user.Id);
            // if (seller != null)
            // {
            //     claims.Add(new Claim("SellerId", seller.Id.ToString()));
            // }
            claims.Add(new Claim("SellerId", user.Seller!.Id.ToString()));
        }
        var token = _jwtService.GenerateAccessToken(claims);

        var result = new Response.IdenetityResponse()
        {
            AccessToken = token
        };
        return result;
    }
}