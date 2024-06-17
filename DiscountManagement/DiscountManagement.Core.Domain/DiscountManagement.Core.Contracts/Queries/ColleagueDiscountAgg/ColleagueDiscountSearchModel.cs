using MediatR;

namespace DiscountManagement.Core.Contracts.Queries.ColleagueDiscountAgg
{
    public class ColleagueDiscountSearchModel:IRequest<ColleagueDiscountSearchModelResult>
    {
        public long ProductId { get; set; }

    }

    public class ColleagueDiscountSearchModelResult
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Product { get; set; }
        public int DiscountRate { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}