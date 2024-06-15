using Microsoft.EntityFrameworkCore;

namespace ProductAgg.Infrastructure.Queries
{
    public class ProductQueryDbContext:DbContext
    {
        public ProductQueryDbContext(DbContextOptions<ProductQueryDbContext>options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
