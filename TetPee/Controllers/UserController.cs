using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TetPee.Repository.Data;
using TetPee.Repository.Entity;
using TetPee.Service.User;

namespace TetPee.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController:  ControllerBase
{
    private readonly AppDbContext _dbContext;
    private readonly IService _userService;
    private readonly Service.MediaService.IService _mediaService;
    
    public UserController(AppDbContext dbContext,  IService userService, Service.MediaService.IService mediaService )
    {
        _dbContext = dbContext;
        _userService = userService;
        _mediaService = mediaService;
    }

    [HttpGet(template: "")]
    public async Task<IActionResult> GetUser(string? searchTerm, int pageSize = 10, int pageIndex = 1)
    {
        var users = await _userService.GetUsers(searchTerm, pageSize, pageIndex);
        return Ok(users);
    }
    
    [HttpGet(template: "{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var user = await _userService.GetUserById(id);
        return Ok(user);
    }
    
    [HttpPut(template: "{id}")]
    public async Task<IActionResult> UpdateUsers(Guid id, [FromBody] Request.UpdateUserRequest request)
    {
        var isSuccess = await _userService.UpdateUser(id, request);
        if (!isSuccess)
        {
            return NotFound("Không tìm thấy người để cập nhật.");
        }
        return Ok("Cập nhật người dùng thành công.");
    }
    
    [HttpDelete(template: "{id}")]
    public async Task<IActionResult> DeleteUsers(Guid id)
    {
        var isSuccess = await _userService.DeleleUser(id);
        if (!isSuccess)
        {
            return NotFound("Không tìm thấy người để xóa.");
        }
        return Ok("Xóa người dùng thành công");
    }
    
    [HttpPost(template: "")]
    public async Task<IActionResult> CreateUser([FromForm]  Request.CreateUserRequest request, CancellationToken cancellationToken)
    {
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password,
        };
        if (request.Avatar != null)
        {
            var media = await _mediaService.UploadImageAsync(request.Avatar);
            user.ImageUrl = media;
        }
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return Ok("Create user successfully");
    }
    
    
    
}