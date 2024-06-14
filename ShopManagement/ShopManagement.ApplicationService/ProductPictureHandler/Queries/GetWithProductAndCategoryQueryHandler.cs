using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.Queries.ProductPictureAgg;

namespace ShopManagement.ApplicationService.ProductPictureHandler.Queries
{
    public class GetWithProductAndCategoryQueryHandler : IRequestHandler<GetWithProductAndCategory, GetWithProductAndCategoryResult>
    {
        private readonly IProductPictureQueryRepository _repository;

        public GetWithProductAndCategoryQueryHandler(IProductPictureQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetWithProductAndCategoryResult> Handle(GetWithProductAndCategory request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
