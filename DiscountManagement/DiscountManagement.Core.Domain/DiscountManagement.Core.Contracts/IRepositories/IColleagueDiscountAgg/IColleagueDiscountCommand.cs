using DiscountManagement.Core.Domain.ColleagueDiscountAgg;

namespace DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg
{
    public interface IColleagueDiscountCommand
    {
        Task<long> Command(ColleagueDiscount colleagueDiscount);

    }
}
