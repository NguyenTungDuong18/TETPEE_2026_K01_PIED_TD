using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace TetPee.Service.JwtService;

public interface IServices
{
    public string GenerateAccessToken(IEnumerable<Claim> claims);
    
    ClaimsPrincipal ValidateToken(string token);
}