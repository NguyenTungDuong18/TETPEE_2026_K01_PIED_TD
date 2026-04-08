using Microsoft.AspNetCore.Mvc;
using TetPee.Repositoty;
using TetPee.Service.Category;
using TetPee.Service.Models;

namespace TetPee.API.Controllers;


[ApiController]
[Route("[controller]")]
public class CateController:ControllerBase
{
    private readonly IService _categoryService;
    
    public CateController(IService userService)
    {
        _categoryService = userService;
    }

    [HttpGet(template: "")]
    public async Task<IActionResult>  GetCategory()
    {
        var result = await _categoryService.GetCategory();
        return Ok(ApiResponseFactory.SuccessReponse(result, "Cate retrieved successfully", HttpContext.TraceIdentifier));
    }
    
    [HttpGet(template: "{parentId}/children")]
    public async Task<IActionResult>  GetCategory(Guid parentId)
    {
        var result = await _categoryService.GetChildByCategoriesId(parentId);
        return Ok(ApiResponseFactory.SuccessReponse(result, "Cate retrieved successfully", HttpContext.TraceIdentifier));
    }
}