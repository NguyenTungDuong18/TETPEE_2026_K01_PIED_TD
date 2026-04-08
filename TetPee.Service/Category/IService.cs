namespace TetPee.Service.Category;

public interface IService
{
    public Task<List<Response.GetCategoriesResponse>> GetCategory();
    public Task<List<Response.GetCategoriesResponse?>> GetChildByCategoriesId(Guid ParentId);
}