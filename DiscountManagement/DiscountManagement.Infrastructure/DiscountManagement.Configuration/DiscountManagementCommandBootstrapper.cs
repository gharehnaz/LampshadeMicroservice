using DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg;
using DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg;
using DiscountManagement.Infrastructure.Commad;
using DiscountManagement.Infrastructure.Commad.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DiscountManagement.Configuration
{
    public class DiscountManagementCommandBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IColleagueDiscountCommandRepository, ColleagueDiscountCommandRepository>();
            services.AddTransient<ICustomerDiscountCommandRepository, CustomerDiscountCommandRepository>();
            services.AddDbContext<DiscountManagementCommandDbContext>(x => x.UseSqlServer(connectionString));


        }
    }
}
