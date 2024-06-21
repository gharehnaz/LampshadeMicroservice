using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Core.Domain.InventoryAgg;

namespace InventoryManagement.Infrastructure.Command.Repository
{
    public class InventoryCommandRepository : IInventoryCommandRepository
    {
        public Task<long> Command(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
