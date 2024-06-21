using DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg;
using DiscountManagement.Core.Contracts.Queries.ColleagueDiscountAgg;

namespace DiscountManagement.Infrastructure.Query.Repository
{
    public class ColleagueDiscountQueryRepsitory : IColleagueDiscountQueryRepository
    {
        public Task<GetDetailsColleagueDiscountResult> Query(GetDetailsColleagueDiscount id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColleagueDiscountSearchModelResult>> Query(ColleagueDiscountSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
