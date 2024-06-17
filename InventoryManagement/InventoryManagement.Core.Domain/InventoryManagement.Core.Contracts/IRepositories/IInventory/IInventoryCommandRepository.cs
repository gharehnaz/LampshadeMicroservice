using InventoryManagement.Core.Domain.InventoryAgg;

namespace InventoryManagement.Core.Contracts.IRepositories.IInventory
{
    public interface IInventoryCommandRepository
    {
        Task<long> Command(Inventory inventory);

    }
}
