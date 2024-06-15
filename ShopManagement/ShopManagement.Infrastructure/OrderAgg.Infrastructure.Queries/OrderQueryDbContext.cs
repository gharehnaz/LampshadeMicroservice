using Microsoft.EntityFrameworkCore;

namespace OrderAgg.Infrastructure.Queries
{
    public class OrderQueryDbContext:DbContext
    {
        public OrderQueryDbContext(DbContextOptions<OrderQueryDbContext>options):base(options)
        {
            
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
