using MediatR;

namespace DiscountManagement.Core.Contracts.Commands.CustomerDiscountAgg
{
    public class CreateCustomerDiscount:IRequest<CreateCustomerDiscountResult>
    {
        public long ProductId { get; set; }

        public int DiscountRate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
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
    public class CreateCustomerDiscountResult
    {
        public long Id { get; set; }
    }
}
