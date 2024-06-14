using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.SlideAgg.Entities;

namespace SlideAgg.Infrastructure.Commands
{
    public class SlideCommandDbContext:DbContext
    {
        public SlideCommandDbContext(DbContextOptions<SlideCommandDbContext> options) :base(options)
        {
            
        }

        public DbSet<Slide> Slides { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
