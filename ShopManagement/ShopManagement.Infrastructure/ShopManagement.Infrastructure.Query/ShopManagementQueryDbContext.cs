using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.OrderAgg.Entities;
using ShopManagement.Core.Domain.ProductAgg.Entities;
using ShopManagement.Core.Domain.ProductCategoryAgg.Entities;
using ShopManagement.Core.Domain.ProductPictureAgg.Entities;
using ShopManagement.Core.Domain.SlideAgg.Entities;

namespace ShopManagement.Infrastructure_
{
    public class ShopManagementQueryDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ShopManagementQueryDbContext(DbContextOptions<ShopManagementQueryDbContext> options) : base(options)
        {
        }
    
    }
}
