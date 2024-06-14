using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;
using ShopManagement.Core.Domain.OrderAgg.Entities;

namespace ShopManagement.Core.Contracts.IRepositories.IOrder
{
    public interface IOrderQueryRepository
    {
        Task<double> Query(GetAmountBy getAmountBy);
        Task<List<GetOrderItemResult>> Query(GetOrderItem getOrderItem);
        Task<List<OrderSearchResult>> Query(OrderSearch searchModel);
    }
}
