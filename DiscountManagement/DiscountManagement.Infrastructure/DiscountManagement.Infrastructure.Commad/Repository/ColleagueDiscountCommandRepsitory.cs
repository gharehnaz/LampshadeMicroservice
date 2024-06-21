using DiscountManagement.Core.Contracts.IRepositories.IColleagueDiscountAgg;
using DiscountManagement.Core.Domain.ColleagueDiscountAgg;

namespace DiscountManagement.Infrastructure.Commad.Repository
{
    public class ColleagueDiscountCommandRepository : IColleagueDiscountCommandRepository
    {
        public Task<long> Command(ColleagueDiscount colleagueDiscount)
        {
            throw new NotImplementedException();
        }
    }
}
