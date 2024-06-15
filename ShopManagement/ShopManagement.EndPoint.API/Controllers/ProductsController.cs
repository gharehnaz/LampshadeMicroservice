using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopManagement.Core.Contracts.Commands.ProductAgg;
using ShopManagement.Core.Contracts.Queries.ProductAgg;

namespace ShopManagement.EndPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProduct create)
        {
            return Ok(await _mediator.Send(create));
        }

        [HttpGet("GetProductDetails")]
        public async Task<IActionResult> Get([FromQuery] GetProductDetails getProductDetails)
        {
            return Ok(await _mediator.Send(getProductDetails));
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> Get([FromQuery] GetProducts getProducts)
        {
            return Ok(await _mediator.Send(getProducts));
        }

        [HttpGet("ProductSearch")]
        public async Task<IActionResult> Search([FromQuery] ProductSearch productSearch)
        {
            return Ok(await _mediator.Send(productSearch));
        }

        [HttpGet("GetProductWithCategory")]
        public async Task<IActionResult> Search([FromQuery] GetProductWithCategory getProductWithCategory)
        {
            return Ok(await _mediator.Send(getProductWithCategory));
        }
    }
}
