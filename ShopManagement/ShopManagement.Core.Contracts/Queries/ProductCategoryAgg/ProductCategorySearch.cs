using MediatR;

namespace ShopManagement.Core.Contracts.Queries.ProductCategoryAgg
{
    public class ProductCategorySearch : IRequest<List<ProductCategorySearchResult>>
    {
        public string Name { get; set; }

    }
    public class ProductCategorySearchResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public long ProductsCount { get; set; }
    }
}
