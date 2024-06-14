using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.ProductAgg.Entities;

namespace ProductAgg.Infrastructure.Commands
{
    public class ProductCommandDbContext:DbContext
    {
        public ProductCommandDbContext(DbContextOptions<ProductCommandDbContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
