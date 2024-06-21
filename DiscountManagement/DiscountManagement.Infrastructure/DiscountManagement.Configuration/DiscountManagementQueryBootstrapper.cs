using DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg;
using DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg;
using DiscountManagement.Infrastructure.Commad.Repository;
using DiscountManagement.Infrastructure.Commad;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DiscountManagement.Infrastructure.Query;
using DiscountManagement.Infrastructure.Query.Repository;

namespace DiscountManagement.Configuration
{
    public class DiscountManagementQueryBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IColleagueDiscountQueryRepository, ColleagueDiscountQueryRepsitory>();
            services.AddTransient<ICustomerDiscountQueryRepository, CustomerDiscountQueryRepository>();
            services.AddDbContext<DiscountManagementQueryDbContext>(x => x.UseSqlServer(connectionString));


        }
    }
}
