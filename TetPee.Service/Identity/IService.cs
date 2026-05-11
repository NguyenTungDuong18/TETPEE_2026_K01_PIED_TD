namespace TetPee.Service.Identity;

public interface IService
{
    public Task<Response.IdenetityResponse> Login(String email, String password);
}