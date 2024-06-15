using Microsoft.EntityFrameworkCore;
using ProductPictureAgg.Infrastructure.Queries.Common;

namespace ProductPictureAgg.Infrastructure.Queries
{
    public class ProductPictureQueryDbContext:DbContext
    {
        public ProductPictureQueryDbContext(DbContextOptions<ProductPictureQueryDbContext> options):base(options) 
        {
            
        }
        public DbSet<ProductPicture> ProductPictures { get; set; }
    }
}
