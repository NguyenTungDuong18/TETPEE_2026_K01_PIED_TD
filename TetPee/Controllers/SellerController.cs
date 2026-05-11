using Microsoft.AspNetCore.Mvc;
using TetPee.Service.Seller;

namespace TetPee.Controllers;

[ApiController]
[Route("[controller]")]
public class SellerController: ControllerBase
{
        private readonly IService _sellerService;

        public SellerController(IService sellerService)
        {
            _sellerService = sellerService;
        }
    
        [HttpGet(template: "")]
        public async Task<IActionResult> GetSeller(string? searchTerm,int pageSize = 10, int pageIndex = 1)
        {
            var result = await _sellerService.GetSellers(searchTerm, pageSize, pageIndex);
            return Ok(result);
        }
    
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetSellerById(Guid id)
        {
            var result = await _sellerService.GetSellerById(id);
            return Ok(result);
        }
        
        [HttpPost("")]
        public async Task<IActionResult> CreateSeller(Request.CreateSellerRequest request)
        {
            var result = await _sellerService.CreateSeller(request);
            return Ok(result);
        }
}