using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace TetPee.Service.JwtService;

public class Services :IServices
{
    
    private readonly JwtOptions _jwtOptions = new ();

    public Services(IConfiguration configuration)
    {
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptions);
        //Ánh xạ dữ liệu từ AppSettings vào obj JwtOptions
    }

    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey));
        //tạo ra 1 key để mã hóa token, sử dụng secretKey từ JwtOptions
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        //tạo 1 đối tượng SigningCredentials để xác định thuật toán mã hóa và key sử dụng để ký token
        var tokenOptions = new JwtSecurityToken(
            issuer: _jwtOptions.Issuer,//cái token này được tạo ra bởi ai, tổ chức nào
            audience: _jwtOptions.Audience,//cái token này là dành cho ai tổ chức nào
            claims: claims,//Những thông tin mà bạn muốn lưu trữ trong token, thường là những thông tin về ng dùng
                           //như id, email, vai trò, ... nằm trong payload
            
            expires:DateTime.Now.AddMinutes(_jwtOptions.ExpireMinutes),//token này sẽ hết hạn trong bao lâu
            signingCredentials: signingCredentials);
        
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        //Sau đó gọi JwtSecurityTokenHandler
        //để tạo ra token dưới dạng chuỗi (string) từ các thông tin đã cung cấp ở trên
        return tokenString;
        throw new NotImplementedException();
    }

    public ClaimsPrincipal ValidateToken(string token)
    {
        throw new NotImplementedException();
    }
}