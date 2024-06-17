namespace DiscountManagement.Core.Contracts.IRepositories.ICustomerDiscountAgg
{
    public interface ICustomerDiscountQueryRepository
    {
        Task<GetDetailsCustomerDiscountResult> Query(GetDetailsCustomerDiscount getDetailsCustoemrDiscount);
        Task<List<CustomerDiscountSearchModelResult>> Query(CustomerDiscountSearchModel searchModel);
    }
}
