using ShopManagement.Core.Contracts.Queries.SlideAgg;

namespace ShopManagement.Core.Contracts.IRepositories.ISlide
{
    public interface ISlideQueryRepository
    {
        Task<GetSlideDetailsResult> Query(GetSlideDetails getSlideDetails);
        Task<List<GetSlidesResult>> Query(GetSlides getSlides);
    }
}
