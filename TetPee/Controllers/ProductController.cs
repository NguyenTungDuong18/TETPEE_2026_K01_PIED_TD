using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Api.Extensions;
using TetPee.Service.Product;

namespace TetPee.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController: ControllerBase
{
    private readonly IService _productService;
    public ProductController(IService productService)
    {
        _productService = productService;
    }
    [Authorize(Policy = JwtExtensions.SellerOrUserPolicy)]
    [HttpPost("")]
    public async Task<IActionResult> CreateProduct(Request.CreateProductRequest request)
    {
        var result = await _productService.CreateProduct(request);
        return Ok(result);
    }
}