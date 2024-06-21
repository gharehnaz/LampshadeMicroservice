using InventoryManagement.Core.Contracts.Commands.InventoryAgg;
using InventoryManagement.Core.Contracts.IRepositories.IInventory;
using InventoryManagement.Core.Domain.InventoryAgg;
using MediatR;

namespace InventoryManagement.Core.ApplicationService.InventoryAgg.Commands
{
    public class InventoryCommandHandler : IRequestHandler<CreateInventory, CreateInventoryResult>
    {
        private readonly IInventoryCommandRepository _commandRepository;
        public InventoryCommandHandler(IInventoryCommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }
        public async Task<CreateInventoryResult> Handle(CreateInventory request, CancellationToken cancellationToken)
        {
            var inventory = new Inventory(request.ProductId, request.UnitPrice);
            await _commandRepository.Command(inventory);
            var result=new CreateInventoryResult { Id=inventory.Id};
            return result;

        }
    }
}
