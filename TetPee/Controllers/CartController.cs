using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Service.Cart;
using TetPee.Service.Model;

namespace TetPee.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class CartController: ControllerBase
{
    private readonly IService _cartService;

    public CartController(IService cartService)
    {
        _cartService = cartService;
    }
    
    [HttpPost(template: "")]
    public async Task<IActionResult> CreateCart()
    {
         await _cartService.CreateCart();
        return Ok(ApiResponseFactory.SuccessResponse(null, "Cart retrieved", HttpContext.TraceIdentifier));
    }
    
    [HttpPost(template: "product")]
    public async Task<IActionResult> AddProductToCart(Request.AddProductToCartRequest request)
    {
        await _cartService.AddProductToCart(request);
        return Ok(ApiResponseFactory.SuccessResponse( "Add Cart retrieved", HttpContext.TraceIdentifier));
    }
    
    [HttpDelete(template: "product")]
    public async Task<IActionResult> DeleteProductToCart(Request.RemoveProductFromCartRequest request)
    {
        await _cartService.RemoveProductFromCart(request);
        return Ok(ApiResponseFactory.SuccessResponse( "Remove Cart retrieved", HttpContext.TraceIdentifier));
    }
    
    [HttpGet(template: "product")]
    public async Task<IActionResult> GetCart()
    {
        var result = await _cartService.GetCart();
        return Ok(ApiResponseFactory.SuccessResponse( result,"Get Cart retrieved", HttpContext.TraceIdentifier));
    }
}