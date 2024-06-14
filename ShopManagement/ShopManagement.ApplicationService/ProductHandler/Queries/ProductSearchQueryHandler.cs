using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.Queries.ProductAgg;

namespace ShopManagement.ApplicationService.ProductHandler.Queries
{
    public class ProductSearchQueryHandler : IRequestHandler<ProductSearch, List<ProductSearchResult>>
    {
        private readonly IProductQueryRepository _repository;

        public ProductSearchQueryHandler(IProductQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<ProductSearchResult>> Handle(ProductSearch request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
