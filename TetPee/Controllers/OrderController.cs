using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TetPee.Service.Model;
using TetPee.Service.Order;

namespace TetPee.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class OrderController: ControllerBase
{
    private readonly IService _orderService;

    public OrderController(IService orderService)
    {
        _orderService = orderService;
    }
    
    [HttpPost(template: "")]
    public async Task<IActionResult> CreateOrder(Request.CreateOrderRequest request)
    {
        var result = await _orderService.CreateOrder(request);
        return Ok(ApiResponseFactory.SuccessResponse(result, "Order Created", HttpContext.TraceIdentifier));
    }
    
    [HttpPost(template: "sepay/webhook")]
    public async Task<IActionResult> SepayWebhook(Request.SepayWebhookRequest request)
    {
        await _orderService.SepayWebhookHandler(request);
        return Ok(ApiResponseFactory.SuccessResponse("", " Webhook response", HttpContext.TraceIdentifier));
    }
}