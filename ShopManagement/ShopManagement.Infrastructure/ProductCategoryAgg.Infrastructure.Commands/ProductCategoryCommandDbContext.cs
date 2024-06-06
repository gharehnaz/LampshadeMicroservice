using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.ProductCategoryAgg.Entities;
namespace ProductCategoryAgg.Infrastructure.Commands
{
    public class ProductCategoryCommandDbContext: DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public ProductCategoryCommandDbContext(DbContextOptions<ProductCategoryCommandDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
