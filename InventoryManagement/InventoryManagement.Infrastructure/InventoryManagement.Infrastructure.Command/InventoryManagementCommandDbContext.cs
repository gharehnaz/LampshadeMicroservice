using InventoryManagement.Core.Domain.InventoryAgg;
using InventoryManagement.Infrastructure.Command.Mapping;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Command
{
    public class InventoryManagementCommandDbContext:DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }
        public InventoryManagementCommandDbContext(DbContextOptions<InventoryManagementCommandDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(InventoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
