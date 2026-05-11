using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Repositoty;

namespace TetPee.Service.Category;

public class Service : IService
{
    private readonly AppDbContext _dbContext;

    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<List<Response.GetCategoriesResponse>> GetCategory()
    {
        var query = _dbContext.Cates.Where(x => true);

        query = query.OrderBy(x => x.Name);

        var selectedQuery = query
            .Select(x => new Response.GetCategoriesResponse()
            {
                Id = x.Id,
                Name = x.Name,
                ParentId = x.ParentId
            });

        var listResult = await selectedQuery.ToListAsync();

        return listResult;
    }

    public async Task<List<Response.GetCategoriesResponse?>> GetChildByCategoriesId(Guid ParentId)
    {
        var query = _dbContext.Cates.Where(x => x.ParentId == ParentId);

        query = query.OrderBy(x => x.Name);

        var selectedQuery = query
            .Select(x => new Response.GetCategoriesResponse()
            {
                Id = x.Id,
                Name = x.Name,
                ParentId = x.ParentId
            });

        var listResult = await selectedQuery.ToListAsync();

        return listResult;
    }
}