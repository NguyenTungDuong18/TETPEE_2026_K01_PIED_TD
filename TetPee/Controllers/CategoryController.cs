using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Repository.Data;
using TetPee.Service.Category;
using TetPee.Service.Model;


namespace TetPee.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController: ControllerBase
{
    private readonly IService _categoryService;
    
    public CategoryController(IService categoryService)
    {
        _categoryService = categoryService;
    }

    [Authorize]
    [HttpGet(template: "")]
    public async Task<IActionResult> GetCategory()
    {
        var result = await _categoryService.GetCategory();
        return Ok(ApiResponseFactory.SuccessResponse(result, "Categories retrieved", HttpContext.TraceIdentifier));
    }
    
    [HttpGet(template: "{parentId}/childrens")]
    public async Task<IActionResult> GetCategory(Guid parentId)
    {
        var result = await _categoryService.GetChildrenByCategory(parentId);
        return Ok(ApiResponseFactory.SuccessResponse(result, "Child Categories retrieved", HttpContext.TraceIdentifier));
    }
}