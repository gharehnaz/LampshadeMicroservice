namespace DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg
{
    public interface IColleagueDiscountQuery
    {
        Task<GetDetailsColleagueDiscountResult> Query(GetDetailsColleagueDiscount id);
        Task<List<ColleagueDiscountSearchModelResult>> Query(ColleagueDiscountSearchModel searchModel);
    }
}
