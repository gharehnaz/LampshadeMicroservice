using InventoryManagement.Core.Domain.InventoryAgg;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Query
{
    public class InventoryManagementQueryDbContext:DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }

        public InventoryManagementQueryDbContext(DbContextOptions<InventoryManagementQueryDbContext> options) :base(options)
        {
                
        }
    }
}
