using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.ApplicationService.ProductCategoriesHandler.Queries
{
    public class ProductCategorySearchHandler:IRequestHandler<ProductCategorySearch, List<ProductCategorySearchResult>>
    {
        private readonly IProductCategoryQueryRepository _repository;

        public ProductCategorySearchHandler(IProductCategoryQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ProductCategorySearchResult>> Handle(ProductCategorySearch request, CancellationToken cancellationToken)
        {
            var query = _repository.Query(request);

            return await query;
        }
    }
}
