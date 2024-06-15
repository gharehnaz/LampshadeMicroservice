using Microsoft.EntityFrameworkCore;

namespace SlideAgg.Infrastructure.Queries
{
    public class SlideQueryDbContext:DbContext
    {
        public SlideQueryDbContext(DbContextOptions<SlideQueryDbContext>options):base(options)
        {
            
        }
        public DbSet<Slide> Slides { get; set; }
    }
}
