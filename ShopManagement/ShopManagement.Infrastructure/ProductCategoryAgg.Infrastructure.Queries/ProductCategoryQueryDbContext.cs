using Microsoft.EntityFrameworkCore;

namespace ProductCategoryAgg.Infrastructure.Queries
{
    public class ProductCategoryQueryDbContext:DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ProductCategoryQueryDbContext(DbContextOptions options) : base(options)
        {
                
        }
    }
}
