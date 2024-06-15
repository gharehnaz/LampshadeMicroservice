using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.OrderAgg.Entities;
using ShopManagement.Core.Domain.ProductAgg.Entities;
using ShopManagement.Core.Domain.ProductCategoryAgg.Entities;
using ShopManagement.Core.Domain.ProductPictureAgg.Entities;
using ShopManagement.Core.Domain.SlideAgg.Entities;
using ShopManagement.Infrastructure.Command.Mapping;


namespace ShopManagement.Infrastructure.Command
{
    public class ShopManagementCommandDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ShopManagementCommandDbContext(DbContextOptions<ShopManagementCommandDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}
