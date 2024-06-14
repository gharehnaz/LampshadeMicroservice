using MediatR;

namespace ShopManagement.Core.Contracts.Queries.ProductPictureAgg
{
    public class ProductPictureSearch:IRequest<List<ProductPictureSearchResult>>
    {
        public long ProductId { get; set; }

    }
    public class ProductPictureSearchResult
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public long ProductId { get; set; }
        public bool IsRemoved { get; set; }
    }
}
