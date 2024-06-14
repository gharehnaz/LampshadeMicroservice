using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.Queries.ProductAgg;

namespace ShopManagement.ApplicationService.ProductHandler.Queries
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetails, GetProductDetailsResult>
    {
        private readonly IProductQueryRepository _repository;

        public GetProductDetailsQueryHandler(IProductQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetProductDetailsResult> Handle(GetProductDetails request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
