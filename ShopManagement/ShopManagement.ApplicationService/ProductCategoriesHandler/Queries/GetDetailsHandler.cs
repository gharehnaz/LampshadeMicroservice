using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.ApplicationService.ProductCategoriesHandler.Queries
{
    public class GetDetailsHandler : IRequestHandler<GetDetails, GetDetailsResult>
    {
        private readonly IProductCategoryQueryRepository _repository;

        public GetDetailsHandler(IProductCategoryQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetDetailsResult> Handle(GetDetails request, CancellationToken cancellationToken)
        {
            var query =await  _repository.Query(request);
            return query;
        }
    }
}
