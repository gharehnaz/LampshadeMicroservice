using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Core.Contracts.Queries.InventoryAgg;
using MediatR;

namespace InventoryManagement.Core.ApplicationService.InventoryAgg.Queries
{
    public class InventorySearchQueryHandler:IRequestHandler<InventorySearchModel,List<InventorySearchModelResult>>
    {
        private readonly IInventoryQueryRepository _repository;
        public InventorySearchQueryHandler(IInventoryQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<InventorySearchModelResult>> Handle(InventorySearchModel request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
