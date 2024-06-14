using ShopManagement.Core.Domain.OrderAgg.Entities;

namespace ShopManagement.Core.Contracts.IRepositories.IOrder
{
    public interface IOrderCommandRepository
    {
        Task<long> Command(Order order);

    }
}
