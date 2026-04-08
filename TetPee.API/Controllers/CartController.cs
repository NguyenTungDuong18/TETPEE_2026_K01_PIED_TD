using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Service.CartService;
using TetPee.Service.Models;

namespace TetPee.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class CartController : ControllerBase
{
    private readonly IService _cartService;

    public CartController(IService cartService)
    {
        _cartService = cartService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateCart()
    {
        await _cartService.CreateCart();
        return Ok(ApiResponseFactory.SuccessReponse(null, "Cart created successfully", HttpContext.TraceIdentifier));
    }

    [HttpPost("AddProductToCart")]
    public async Task<IActionResult> AddProductToCart(Request.AddProductRequest request)
    {
        await _cartService.AddProductToCart(request);
        return Ok(ApiResponseFactory.SuccessReponse(null, "Product added successfully", HttpContext.TraceIdentifier));
    }

    [HttpDelete("RemoveProductFromCart")]
    public async Task<IActionResult> RemoveProductFromCart(Request.RemoveProductRequest request)
    {
        await _cartService.RemoveProductFromCart(request);
        return Ok(ApiResponseFactory.SuccessReponse(null, "Product removed successfully", HttpContext.TraceIdentifier));
    }

    [HttpGet("GetCart")]
    public async Task<IActionResult> GetCart()
    {
        var result = await _cartService.GetCart();
        return Ok(ApiResponseFactory.SuccessReponse(result, "successfully", HttpContext.TraceIdentifier));
    }
}