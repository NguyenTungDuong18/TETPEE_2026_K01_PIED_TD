namespace TetPee.Service.User;

public interface IService
{
    public Task<Base.Response.PageResult<Response.GetUserResponse>> GetUsers(
        string? searchTerm,
        int pageSize,
        int pageIndex);
    
    public Task<Response.GetUserResponse?> GetUserById(Guid id);
    
    public Task<bool>UpdateUser(Guid id, Request.UpdateUserRequest request);
    public Task<bool>DeleleUser(Guid id);
    public Task<string>CreateUser(Request.CreateUserRequest request);
}