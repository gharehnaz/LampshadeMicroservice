using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Infrastructure.Command;
using InventoryManagement.Infrastructure.Command.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagement.Configuration
{
    public class InventoryManagementCommandBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IInventoryCommandRepository, InventoryCommandRepository>();
            services.AddDbContext<InventoryManagementCommandDbContext>(x => x.UseSqlServer(connectionString));


        }
    }
}
