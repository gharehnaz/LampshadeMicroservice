using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Domain.OrderAgg.Entities;

namespace OrderAgg.Infrastructure.Commands
{
    public class OrderCommandDbContext : DbContext
    {
        public OrderCommandDbContext(DbContextOptions<OrderCommandDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
