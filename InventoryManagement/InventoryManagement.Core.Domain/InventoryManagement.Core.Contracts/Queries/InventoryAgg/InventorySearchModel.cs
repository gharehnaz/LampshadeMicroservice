using MediatR;

namespace InventoryManagement.Core.Contracts.Queries.InventoryAgg
{
    public class InventorySearchModel:IRequest<List<InventorySearchModelResult>>
    {
        public long ProductId { get; set; }
        public bool InStock { get; set; }
    }

    public class InventorySearchModelResult
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
        public long CurrentCount { get; set; }
        public string CreationDate { get; set; }
    }
}