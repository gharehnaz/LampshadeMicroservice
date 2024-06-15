using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopManagement.Core.Contracts.Commands.SlideAgg;
using ShopManagement.Core.Contracts.Queries.ProductAgg;
using ShopManagement.Core.Contracts.Queries.SlideAgg;

namespace ShopManagement.EndPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SlidesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateSlide create)
        {
            return Ok(await _mediator.Send(create));
        }

        [HttpGet("GetSlideDetails")]
        public async Task<IActionResult> Get([FromQuery] GetSlideDetails getSlideDetails)
        {
            return Ok(await _mediator.Send(getSlideDetails));
        }

        [HttpGet("GetSlides")]
        public async Task<IActionResult> Get([FromQuery] GetSlides getSlides)
        {
            return Ok(await _mediator.Send(getSlides));
        }

    }
}
