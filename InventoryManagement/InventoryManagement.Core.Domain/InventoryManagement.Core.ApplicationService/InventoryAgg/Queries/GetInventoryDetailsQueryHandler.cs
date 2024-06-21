using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Core.Contracts.Queries.InventoryAgg;
using MediatR;

namespace InventoryManagement.Core.ApplicationService.InventoryAgg.Queries
{
    public class GetInventoryDetailsQueryHandler : IRequestHandler<GetInventoryDetails, GetInventoryDetailsResult>
    {
        private readonly IInventoryQueryRepository _repository;
        public GetInventoryDetailsQueryHandler(IInventoryQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetInventoryDetailsResult> Handle(GetInventoryDetails request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);      
        }
    }
}
