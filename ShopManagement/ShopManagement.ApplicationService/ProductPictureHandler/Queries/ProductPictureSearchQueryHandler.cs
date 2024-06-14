using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.Queries.ProductPictureAgg;

namespace ShopManagement.ApplicationService.ProductPictureHandler.Queries
{
    public class ProductPictureSearchQueryHandler : IRequestHandler<ProductPictureSearch, List<ProductPictureSearchResult>>
    {
        private readonly IProductPictureQueryRepository _repository;

        public ProductPictureSearchQueryHandler(IProductPictureQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<ProductPictureSearchResult>> Handle(ProductPictureSearch request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
