using DiscountManagement.Core.Domain.ColleagueDiscountAgg;
using DiscountManagement.Core.Domain.CustomerDiscountAgg;
using Microsoft.EntityFrameworkCore;

namespace DiscountManagement.Infrastructure.Query
{
    public class DiscountManagementQueryDbContext:DbContext
    {
        public DbSet<CustomerDiscount> CustomerDiscounts { get; set; }
        public DbSet<ColleagueDiscount> ColleagueDiscounts { get; set; }
        public DiscountManagementQueryDbContext(DbContextOptions<DiscountManagementQueryDbContext>options):base(options)
        {
            
        }
    }
}
