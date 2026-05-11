using Microsoft.AspNetCore.Mvc;
using TetPee.Repositoty;
using TetPee.Repositoty.Entity;
using TetPee.Service.User;

namespace TetPee.API.Controllers;
//Migration sẽ thay mặt mình viết các câu select, create, ... để tạo ra DB và lưu lại lịch sử mỗi khi update DB

//Khai báo các API trg hệ thống

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    private readonly IService _userService;
    private readonly Service.MediaService.IService _mediaService;

    //cái này nâng cao lúc sau sẽ giải thích
    public UserController(AppDbContext dbContext, IService userService, Service.MediaService.IService mediaService)
    {
        _dbContext = dbContext;
        _userService = userService;
        _mediaService = mediaService;
    }

    //HTTP Method: GET,POST,DELETE,PUT,PATCH
    //PARAM:Query string, Path Param, Body Param

    //Query string: http://localhost:5000/User?name=abc&age=20
    //name va age là query string
    //Query string nằm sau dấu ?

    //Path (route) Param: http://localhost:5000/User/123
    //123 là path param hoặc route param
    //Path param nằm trong đường dẫn

    //GET là không có body
    //POST ,PUT, PATCH có body

    //Tại sao phải dùng body: tránh để lộ những thông tin không mong muốn 
    //Ví dụ: Username,Pass
    //ko thể http://localhost:5000/login?username=abc&password=123

    //Chuẩn REST FUll API
    //get all users: GET http://localhost:5000/User
    //create user: POST http://localhost:5000/User
    //get user by id: GET http://localhost:5000/User/{id}
    //update user by id: PUT http://localhost:5000/User/{id}
    //delete user by id : DELETE http://localhost:5000/User/{id}
    [HttpGet(template: "")]
    public async Task<IActionResult> GetUsers(string? searchTerm, int pageSize = 10, int pageIndex = 1)
    {
        var users = await _userService.GetUsers(searchTerm, pageSize, pageIndex);
        //dùng await ở day boi vi hàm getUsers là 1 async và nếu ở đây la await thì phia tren phai la async ma da la async
        //thi phai tra ra Task(Task dong vai tro nhu 1 loi hua se tra ra 1 cai gi do)
        // throw new Exception("Get Users Errors");
        return Ok(users);
    }

    //IActionResult giúp HTTP trả ra được nhiều kiểu dữ liệu khác nhau như: OK, 404, ...
    [HttpGet(template: "{id}")]
    public async Task<IActionResult> GetUsersByid(Guid id)
    {
        var user = await _userService.GetUsersByid(id);
        return Ok("Get all users");
    }
    
    // [HttpPost(template:"")]
    // public IActionResult CreateUsers([FromBody] Request.CreateUserRequest request)
    // {
    //     // var users = _dbContext.Users.ToList();
    //     Console.WriteLine(request);
    //     return Ok("Get all users");
    // }

    [HttpPut(template: "{id}")]
    public IActionResult UpdateUser(Guid id, [FromBody] Request.UpdateUserRequest request)
    {
        // var users = _dbContext.Users.ToList();
        return Ok("Create user");
    }

    [HttpDelete(template: "{id}")]
    public IActionResult DeleteUser(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        return Ok("Delete user");
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateUsers([FromForm] Request.CreateUserRequest request, CancellationToken cancellationToken)
    {
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password // Chưa hash, chỉ demo
        };
        
        if(request.Avatar != null)
        {
            var media = await _mediaService.UploadImageAsync(request.Avatar);
            user.ImageUrl = media;
        }
        
        _dbContext.Users.Add(user);
        
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return Ok("Create user successfully");
    }

    // [HttpGet(template: "")]
    // public async Task<IActionResult>  GetAllCategory()
    // {
    //     var cates = await _userService.GetAllCategory();
    //     return Ok(cates);
    // }
    //
    // [HttpGet(template: "{id}")]
    // public async Task<IActionResult> GetAllChildrenById(Guid id)
    // {
    //     var cates = await _userService.GetChildCategories(id);
    //     return Ok(cates);
    // }
    //
    // [HttpGet(template: "")]
    // public async Task<IActionResult> GetAllSeller(String? searchTerm)
    // {
    //     return Ok("Get all sellers");
    // }
}