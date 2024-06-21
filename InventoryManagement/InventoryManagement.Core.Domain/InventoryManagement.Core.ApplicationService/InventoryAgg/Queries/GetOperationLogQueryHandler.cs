using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Core.Contracts.Queries.InventoryAgg;
using MediatR;

namespace InventoryManagement.Core.ApplicationService.InventoryAgg.Queries
{
    public class GetOperationLogQueryHandler : IRequestHandler<GetOperationLog, List<GetOperationLogResult>>
    {
        private readonly IInventoryQueryRepository _repository;
        public GetOperationLogQueryHandler(IInventoryQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetOperationLogResult>> Handle(GetOperationLog request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
