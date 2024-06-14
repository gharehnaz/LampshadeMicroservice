using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Domain.OrderAgg.Entities;

namespace OrderAgg.Infrastructure.Commands.Repository
{
    public class OrderCommandRepsitory : IOrderCommandRepository
    {
        private readonly OrderCommandDbContext _context;
        public OrderCommandRepsitory(OrderCommandDbContext context)
        {
            _context = context;
        }

        public async Task<long> Command(Order order)
        {
            await _context.AddAsync(order);

            await _context.SaveChangesAsync();
            return order.Id;
        }
    }
}
