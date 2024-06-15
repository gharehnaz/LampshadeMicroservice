using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopManagement.Core.Contracts.Commands.OrderAgg;
using ShopManagement.Core.Contracts.Commands.ProductCategoryAgg;
using ShopManagement.Core.Contracts.Queries.OrderAgg;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.EndPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateOrder create)
        {
            return Ok(await _mediator.Send(create));
        }

        [HttpGet("GetAmountBy")]
        public async Task<IActionResult> Get([FromQuery] GetAmountBy getAmountBy)
        {
            return Ok(await _mediator.Send(getAmountBy));
        }

        [HttpGet("GetOrderItem")]
        public async Task<IActionResult> Get([FromQuery] GetOrderItem getOrderItem)
        {
            return Ok(await _mediator.Send(getOrderItem));
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] OrderSearch orderSearch)
        {
            return Ok(await _mediator.Send(orderSearch));
        }
    }
}
