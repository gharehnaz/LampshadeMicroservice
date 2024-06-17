﻿using MediatR;

namespace InventoryManagement.Core.Contracts.Queries.InventoryAgg
{
    public class GetInventoryDetails: IRequest<GetInventoryDetailsResult>
    {
        public long Id { get; set; }
    }

    public class GetInventoryDetailsResult
    {
        public long Id { get; set; }
        public long ProductId { get; set; }

        public double UnitPrice { get; set; }

        public List<ProductViewModel> Products { get; set; }
    }
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public long CategoryId { get; set; }
        public string CreationDate { get; set; }
    }

}