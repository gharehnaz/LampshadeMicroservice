using MediatR;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.Queries.ProductAgg;
using ShopManagement.Core.Contracts.Queries.ProductPictureAgg;

namespace ShopManagement.ApplicationService.ProductPictureHandler.Queries
{
    public class GetProductPictureDetailsQueryHandler : IRequestHandler<GetProductPictureDetails, GetProductPictureDetailsResult>
    {
        private readonly IProductPictureQueryRepository _repository;

        public GetProductPictureDetailsQueryHandler(IProductPictureQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetProductPictureDetailsResult> Handle(GetProductPictureDetails request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
