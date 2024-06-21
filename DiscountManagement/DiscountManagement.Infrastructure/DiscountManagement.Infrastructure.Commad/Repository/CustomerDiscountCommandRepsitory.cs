using DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg;
using DiscountManagement.Core.Domain.CustomerDiscountAgg;

namespace DiscountManagement.Infrastructure.Commad.Repository
{
    public class CustomerDiscountCommandRepository : ICustomerDiscountCommandRepository
    {
        public Task<long> Command(CustomerDiscount colleagueDiscount)
        {
            throw new NotImplementedException();
        }
    }
}
