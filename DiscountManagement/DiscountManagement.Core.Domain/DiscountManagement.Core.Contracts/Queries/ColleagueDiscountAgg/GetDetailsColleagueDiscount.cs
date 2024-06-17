using MediatR;

namespace DiscountManagement.Core.Contracts.Queries.ColleagueDiscountAgg
{
    public class GetDetailsColleagueDiscount:IRequest<GetDetailsColleagueDiscountResult>
    {
        public long Id { get; set; }
    }

    public class GetDetailsColleagueDiscountResult
    {
        public long ProductId { get; set; }

        public int DiscountRate { get; set; }
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