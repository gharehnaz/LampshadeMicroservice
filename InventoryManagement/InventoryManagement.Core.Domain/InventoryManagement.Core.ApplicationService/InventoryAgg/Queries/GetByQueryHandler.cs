using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Core.Contracts.Queries.InventoryAgg;
using MediatR;

namespace InventoryManagement.Core.ApplicationService.InventoryAgg.Queries
{
    public class GetByQueryHandler : IRequestHandler<GetBy, GetByResult>
    {
        private readonly IInventoryQueryRepository _queryRepository;
        public GetByQueryHandler(IInventoryQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }
        public async Task<GetByResult> Handle(GetBy request, CancellationToken cancellationToken)
        {
            return await _queryRepository.Query(request);
        }
    }
}
