using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Core.Contracts.Queries.InventoryAgg;

namespace InventoryManagement.Infrastructure.Query.Repository
{
    public class InventoryQueryRepository : IInventoryQueryRepository
    {
        public Task<GetInventoryDetailsResult> Query(GetInventoryDetails getInventoryDetails)
        {
            throw new NotImplementedException();
        }

        public Task<GetByResult> Query(GetBy getBy)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventorySearchModelResult>> Query(InventorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetOperationLogResult>> Query(GetOperationLog getOperationLog)
        {
            throw new NotImplementedException();
        }
    }
}
