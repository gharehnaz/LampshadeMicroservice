using MediatR;
using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Core.Contracts.Queries.SlideAgg;

namespace ShopManagement.ApplicationService.SlideHandler.Queries
{
    public class GetSlideDetailsQueryHandler : IRequestHandler<GetSlideDetails, GetSlideDetailsResult>
    {
        private readonly ISlideQueryRepository _repository;

        public GetSlideDetailsQueryHandler(ISlideQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetSlideDetailsResult> Handle(GetSlideDetails request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
