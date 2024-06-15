using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopManagement.Core.Contracts.Commands.OrderAgg;
using ShopManagement.Core.Contracts.Commands.ProductPictureAgg;
using ShopManagement.Core.Contracts.Queries.OrderAgg;
using ShopManagement.Core.Contracts.Queries.ProductAgg;
using ShopManagement.Core.Contracts.Queries.ProductPictureAgg;

namespace ShopManagement.EndPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPicturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductPicturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductPicture create)
        {
            return Ok(await _mediator.Send(create));
        }
        [HttpGet("GetProductPictureDetails")]
        public async Task<IActionResult> Get([FromQuery] GetProductPictureDetails getProductPictureDetails)
        {
            return Ok(await _mediator.Send(getProductPictureDetails));
        }

        [HttpGet("GetWithProductAndCategory")]
        public async Task<IActionResult> Get([FromQuery] GetWithProductAndCategory getWithProductAndCategory)
        {
            return Ok(await _mediator.Send(getWithProductAndCategory));
        }

        [HttpGet("ProductPictureSearch")]
        public async Task<IActionResult> Search([FromQuery] ProductPictureSearch search)
        {
            return Ok(await _mediator.Send(search));
        }

        [HttpGet("GetProductWithCategory")]
        public async Task<IActionResult> Search([FromQuery] GetProductWithCategory getProductWithCategory)
        {
            return Ok(await _mediator.Send(getProductWithCategory));
        }

    }
}
