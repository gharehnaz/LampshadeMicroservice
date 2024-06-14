using MediatR;

namespace ShopManagement.Core.Contracts.Queries.ProductAgg
{
    public class GetProducts:IRequest<GetProductsResult>
    {
    }
    public class GetProductsResult
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
