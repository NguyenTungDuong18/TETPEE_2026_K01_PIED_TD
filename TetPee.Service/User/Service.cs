using Microsoft.EntityFrameworkCore;
using TetPee.Repositoty;

namespace TetPee.Service.User;

public class Service : IService
{
    private readonly AppDbContext _dbContext;

    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Base.Response.PageResult<Response.GetUsersResponse>> GetUsers(string? SearchTerm, int pageSize,
        int pageIndex)
    {
        var query = _dbContext.Users.Where(x => true);

        if (SearchTerm != null)
        {
            query = query.Where(x =>
                x.FirstName.Contains(SearchTerm) || x.LastName.Contains(SearchTerm) || x.Email.Contains(SearchTerm));
        }

        query = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);

        var selectedQuery = query.Select(x => new Response.GetUsersResponse()
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            PhoneNumber = x.PhoneNumber,
            Address = x.Address,
            Role = x.Role,
            // DateOfBirth = x.DateOfBirth,
        });

        var listResult = await selectedQuery.ToListAsync();
        var totalItems = listResult.Count();

        var result = new Base.Response.PageResult<Response.GetUsersResponse>()
        {
            Items = listResult,
            TotalItems = totalItems,
            PageSize = pageSize,
            PageIndex = pageIndex,
        };

        return result;
    }

    public async Task<Response.GetUsersResponse?> GetUsersByid(Guid id)
    {
        var query = _dbContext.Users.Where(x => x.Id == id);

        var selectedQuery = query.Select(x => new Response.GetUsersResponse()
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            PhoneNumber = x.PhoneNumber,
            Address = x.Address,
            Role = x.Role,
            // DateOfBirth = x.DateOfBirth,
        });

        var result = await selectedQuery.FirstOrDefaultAsync();

        return result;
    }

    

    // public Task<Base.Response.PageResult<Response.GetAllSellersResponse>> GetAllSeller(string? searchTerm)
    // {
    //     //lấy seller trong user de lây tên
    //     var query = _dbContext.Users.Where(x => x.Role.Equals("Seller"));
    //
    //     if (searchTerm != null)
    //     {//tìm theo tên
    //         query = query.Where(x => x.FirstName.Contains(searchTerm) || x.LastName.Contains(searchTerm));
    //     }
    //     
    //     // var querySeller = _dbContext.Sellers.Where(x => x.UserId.Equals());
    //     
    //     throw new NotImplementedException();
    // }

    
}