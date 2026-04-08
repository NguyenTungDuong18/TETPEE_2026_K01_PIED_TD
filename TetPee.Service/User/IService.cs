namespace TetPee.Service.User;

public interface IService
{
    public Task<Base.Response.PageResult<Response.GetUsersResponse>> GetUsers(
        string? searchTerm,
        int pageIndex,
        int pageSize);

    public Task<Response.GetUsersResponse?> GetUsersByid(Guid id );
    
    // public Task<Base.Response.PageResult<Response.GetAllSellersResponse>> GetAllSeller(String? searchTerm);
}