namespace ShopManagement.Core.Contracts.IRepositories.ISlide
{
    public interface ISlideQueryRepository
    {
        Task<GetSlideResult> Query(GetSlide getSlide);
        Task<List<GetSlidesResult>> Query(GetSlides getSlides);
    }
}
