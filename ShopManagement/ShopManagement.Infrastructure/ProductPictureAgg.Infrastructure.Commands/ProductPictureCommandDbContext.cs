using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.ProductPictureAgg.Entities;

namespace ProductPictureAgg.Infrastructure.Commands
{
    public class ProductPictureCommandDbContext:DbContext
    {
        public ProductPictureCommandDbContext(DbContextOptions<ProductPictureCommandDbContext>options):base(options)
        {
            
        }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
