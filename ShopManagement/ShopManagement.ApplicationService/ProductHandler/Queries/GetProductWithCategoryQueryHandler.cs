using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.Queries.ProductAgg;

namespace ShopManagement.ApplicationService.ProductHandler.Queries
{
    public class GetProductWithCategoryQueryHandler : IRequestHandler<GetProductWithCategory, GetProductWithCategoryResult>
    {
        private readonly IProductQueryRepository _repository;

        public GetProductWithCategoryQueryHandler(IProductQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetProductWithCategoryResult> Handle(GetProductWithCategory request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
