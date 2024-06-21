using DiscountManagement.Core.Domain.ColleagueDiscountAgg;

namespace DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg
{
    public interface IColleagueDiscountCommandRepository
    {
        Task<long> Command(ColleagueDiscount colleagueDiscount);

    }
}
