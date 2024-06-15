using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Domain.OrderAgg.Entities;

namespace ShopManagement.Infrastructure.Command.Repository
{
    public class OrderCommandRepsitory : IOrderCommandRepository
    {
        private readonly ShopManagementCommandDbContext _context;
        public OrderCommandRepsitory(ShopManagementCommandDbContext context)
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
