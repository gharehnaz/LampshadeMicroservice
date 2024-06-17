using DiscountManagement.Core.Domain.CustomerDiscountAgg;

namespace DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg
{
    public interface ICustomerDiscountCommandRepository
    {
        Task<long> Command(CustomerDiscount colleagueDiscount);

    }
}
