using InventoryManagement.Core.Contracts.Queries.InventoryAgg;
using InventoryManagement.Core.Domain.InventoryAgg;

namespace InventoryManagement.Core.Contracts.IRepositories.IInventory
{
    public interface IInventoryQueryRepository
    {
        Task<GetInventoryDetailsResult> Query(GetInventoryDetails getInventoryDetails);
        Task<GetByResult> Query(GetBy getBy);
        Task<List<InventorySearchModelResult>> Query(InventorySearchModel searchModel);
        Task<List<GetOperationLogResult>> Query(GetOperationLog getOperationLog);
    }
}
