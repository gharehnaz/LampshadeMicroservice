using MediatR;

namespace DiscountManagement.Core.Contracts.Queries.CustomerDiscountAgg
{
    public class GetDetailsCustomerDiscount : IRequest<GetDetailsCustomerDiscountResult>
    {
        public long Id { get; set; }
    }

    public class GetDetailsCustomerDiscountResult
    {
        public long ProductId { get; set; }

        public int DiscountRate { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
        public string Reason { get; set; }
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