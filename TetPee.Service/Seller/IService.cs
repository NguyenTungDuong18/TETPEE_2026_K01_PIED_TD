namespace TetPee.Service.Seller;

public interface IService
{
    public Task<Base.Response.PageResult<Response.GetSellerResponse>> GetSeller(
        string? searchTerm,
        int pageIndex,
        int pageSize);

    public Task<Response.GetSellerByIdResponse?> GetSellerByid(Guid id);

    public Task<string> CreateSeller(Request.CreateSellerRequest request);
}