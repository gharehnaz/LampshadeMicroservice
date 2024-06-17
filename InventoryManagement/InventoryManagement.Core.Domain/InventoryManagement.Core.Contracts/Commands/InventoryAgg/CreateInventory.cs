using MediatR;

namespace InventoryManagement.Core.Contracts.Commands.InventoryAgg
{
    public class CreateInventory:IRequest<CreateInventoryResult>
    {
    }

    public class CreateInventoryResult
    {
    }
}
