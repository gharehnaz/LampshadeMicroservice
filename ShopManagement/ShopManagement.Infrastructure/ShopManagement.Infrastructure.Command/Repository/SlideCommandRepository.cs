using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Core.Domain.SlideAgg.Entities;

namespace ShopManagement.Infrastructure.Command.Repository
{
    public class SlideCommandRepository : ISlideCommandRepository
    {
        private readonly ShopManagementCommandDbContext _context;

        public SlideCommandRepository(ShopManagementCommandDbContext context)
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
