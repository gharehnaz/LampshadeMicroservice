using MediatR;

namespace ShopManagement.Core.Contracts.Queries.OrderAgg
{
    public class GetAmountBy:IRequest<GetAmountByResult>
    {
        public long Id { get; set; }
    }
    public class GetAmountByResult
    {
        public double Amount { get; set; }
    }
}
