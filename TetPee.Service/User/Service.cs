using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Data;

namespace TetPee.Service.User;

public class Service:IService
{
    private readonly AppDbContext _dbContext;

    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Base.Response.PageResult<Response.GetUserResponse>> GetUsers(string? searchTerm, int pageSize, int pageIndex)
    {
        var query = _dbContext.Users.Where(x => true);
        if (searchTerm != null)
        {
            query = query.Where(x =>
                x.FirstName.Contains(searchTerm) ||
                x.LastName.Contains(searchTerm) ||
                x.Email.Contains(searchTerm));
        }
        
        query = query.OrderBy(x => x.Email);
        query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        var selecctedQuery = query
            .Select(x => new Response.GetUserResponse()
            {
                Id = x.Id,
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName,
                ImageUrl = x.ImageUrl,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                role = x.Role
            });
         var listResult =  await selecctedQuery.ToListAsync();
         var totalItems = listResult.Count;

         var result = new Base.Response.PageResult<Response.GetUserResponse>()
         {
             Items = listResult,
             PageIndex = pageIndex,
             PageSize = pageSize,
             Totalitems = totalItems,
         };
         return result;
    }
    
    public async Task<Response.GetUserResponse?> GetUserById(Guid id)
    {
        var query = _dbContext.Users.Where(x=> x.Id == id);

        var selectedQuery = query
            .Select(x => new Response.GetUserResponse()
            {
                Id = x.Id,
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName,
                ImageUrl = x.ImageUrl,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                role = x.Role
            });
        var result = await selectedQuery.FirstOrDefaultAsync();
        return result;
    }

    public async Task<bool> UpdateUser(Guid id, Request.UpdateUserRequest request)
    {
        var user = await _dbContext.Users.FindAsync(id);
        if (user == null)
        {
            return false;
        }

        // user: Là đối tượng cũ mà bạn vừa lôi từ dưới Database lên (ứa đầy đủ thông tin cũ).
        // request: Là thông tin mới mà khách hàng vừa gửi lên.
        // Dấu bằng =: Có nghĩa là "Lấy giá trị mới đè lên giá trị cũ".
        user.Email = request.Email;
        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.HashedPassword = request.Password;
        user.UpdateAt = DateTimeOffset.UtcNow;
        
        _dbContext.Users.Update(user);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleleUser(Guid id)
    {   
        var user = await _dbContext.Users.FindAsync(id);
        if (user == null)
        {
            return false;
        }
        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<string> CreateUser(Request.CreateUserRequest request)
    {
        var user = new Repository.Entity.User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password,
            CreateAt = DateTimeOffset.UtcNow,
        };
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return "Create user successfully";
    }
}