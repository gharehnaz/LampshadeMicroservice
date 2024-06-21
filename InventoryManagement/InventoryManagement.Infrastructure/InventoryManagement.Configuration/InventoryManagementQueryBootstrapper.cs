using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Infrastructure.Query;
using InventoryManagement.Infrastructure.Query.Repository;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Configuration
{
    public class InventoryManagementQueryBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IInventoryQueryRepository, InventoryQueryRepository>();
            services.AddDbContext<InventoryManagementQueryDbContext>(x => x.UseSqlServer(connectionString));


        }
    }
}
