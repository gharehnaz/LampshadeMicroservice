using ShopManagement.Core.Contracts.Queries.OrderAgg;
namespace ShopManagement.Core.Contracts.IRepositories.IOrder
{
    public interface IOrderQueryRepository
    {
        Task<GetAmountByResult> Query(GetAmountBy getAmountBy);
        Task<List<GetOrderItemResult>> Query(GetOrderItem getOrderItem);
        Task<List<OrderSearchResult>> Query(OrderSearch searchModel);
    }
}
