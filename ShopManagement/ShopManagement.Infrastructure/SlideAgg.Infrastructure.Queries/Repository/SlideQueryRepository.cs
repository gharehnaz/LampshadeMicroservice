using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Core.Contracts.Queries.SlideAgg;

namespace SlideAgg.Infrastructure.Queries.Repository
{
    public class SlideQueryRepository: ISlideQueryRepository
    {
        private readonly SlideQueryDbContext _context;
        public SlideQueryRepository(SlideQueryDbContext context)
        {

            _context = context;

        }

        public async Task<GetSlideDetailsResult> Query(GetSlideDetails getSlideDetails)
        {
            return _context.Slides.Select(x => new GetSlideDetailsResult
            {
                Id = x.Id,
                BtnText = x.BtnText,
                Heading = x.Heading,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Text = x.Text,
                Link = x.Link,
                Title = x.Title
            }).FirstOrDefault(x => x.Id == getSlideDetails.Id);
        }

        public async Task<List<GetSlidesResult>> Query(GetSlides getSlides)
        {
            return _context.Slides.Select(x => new GetSlidesResult
            {
                Id = x.Id,
                Heading = x.Heading,
                Picture = x.Picture,
                Title = x.Title,
                IsRemoved = x.IsRemoved,
            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}
