using MediatR;
using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Core.Contracts.Queries.SlideAgg;

namespace ShopManagement.ApplicationService.SlideHandler.Queries
{
    public class GetSlidesQueryHandler : IRequestHandler<GetSlides, List<GetSlidesResult>>
    {
        private readonly ISlideQueryRepository _repository;

        public GetSlidesQueryHandler(ISlideQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetSlidesResult>> Handle(GetSlides request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }

}
