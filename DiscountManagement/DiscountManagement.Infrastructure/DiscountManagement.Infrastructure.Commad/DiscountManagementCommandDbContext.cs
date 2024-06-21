using DiscountManagement.Core.Domain.ColleagueDiscountAgg;
using DiscountManagement.Core.Domain.CustomerDiscountAgg;
using DiscountManagement.Infrastructure.Commad.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DiscountManagement.Infrastructure.Commad
{
    public class DiscountManagementCommandDbContext:DbContext
    {
        public DbSet<CustomerDiscount> CustomerDiscounts { get; set; }
        public DbSet<ColleagueDiscount> ColleagueDiscounts { get; set; }
        public DiscountManagementCommandDbContext(DbContextOptions<DiscountManagementCommandDbContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(CustomerDiscountMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
