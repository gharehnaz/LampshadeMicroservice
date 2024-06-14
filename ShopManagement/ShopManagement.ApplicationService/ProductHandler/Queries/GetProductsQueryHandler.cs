using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.Queries.ProductAgg;

namespace ShopManagement.ApplicationService.ProductHandler.Queries
{
    public class GetProductsQueryHandler : IRequestHandler<GetProducts, List<GetProductsResult>>
    {
        private readonly IProductQueryRepository _repository;

        public GetProductsQueryHandler(IProductQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetProductsResult>> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
