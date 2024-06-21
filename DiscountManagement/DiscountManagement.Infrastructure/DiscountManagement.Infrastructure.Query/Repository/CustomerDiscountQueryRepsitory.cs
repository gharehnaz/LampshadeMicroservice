using DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg;
using DiscountManagement.Core.Contracts.Queries.CustomerDiscountAgg;

namespace DiscountManagement.Infrastructure.Query.Repository
{
    public class CustomerDiscountQueryRepsitory : ICustomerDiscountQueryRepository
    {
        public Task<GetDetailsCustomerDiscountResult> Query(GetDetailsCustomerDiscount getDetailsCustoemrDiscount)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerDiscountSearchModelResult>> Query(CustomerDiscountSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
