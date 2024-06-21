using DiscountManagement.Core.Contracts.Queries.ColleagueDiscountAgg;

namespace DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg
{
    public interface IColleagueDiscountQueryRepository
    {
        Task<GetDetailsColleagueDiscountResult> Query(GetDetailsColleagueDiscount id);
        Task<List<ColleagueDiscountSearchModelResult>> Query(ColleagueDiscountSearchModel searchModel);
    }
}
