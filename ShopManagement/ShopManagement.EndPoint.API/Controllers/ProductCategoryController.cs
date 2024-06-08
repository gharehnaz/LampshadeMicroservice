using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopManagement.Core.Contracts.Commands.ProductCategoryAgg;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.EndPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCategory create)
        {
            return Ok(await _mediator.Send(create));
        }

        [HttpGet("GetDetails")]
        public async Task<IActionResult> Get([FromQuery] GetDetails details)
        {
            return Ok(await _mediator.Send(details));
        }

        //[HttpGet("ProductCategories")]
        //public async Task<IActionResult> Get([FromQuery] GetProductCategories getProductCategories)
        //{
        //    return await Query<GetProductCategories, PagedData<GetProductCategoriesResult>>(getProductCategories);
        //}

        //[HttpGet("Search")]
        //public async Task<IActionResult> Search([FromQuery] ProductCategorySearch productCategorySearch)
        //{
        //    return await Query<ProductCategorySearch, PagedData<ProductCategorySearchResult>>(productCategorySearch);
        //}
    }
}
