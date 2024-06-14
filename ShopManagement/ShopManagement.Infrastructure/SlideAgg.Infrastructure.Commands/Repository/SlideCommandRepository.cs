using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Core.Domain.SlideAgg.Entities;

namespace SlideAgg.Infrastructure.Commands.Repository
{
    public class SlideCommandRepository : ISlideCommandRepository
    {
        private readonly SlideCommandDbContext _context;

        public SlideCommandRepository(SlideCommandDbContext context)
        {

            _context = context;

        }
        public async Task<long> Command(Slide slide)
        {
            await _context.AddAsync(slide);

            await _context.SaveChangesAsync();
            return slide.Id;
        }


    }
}
