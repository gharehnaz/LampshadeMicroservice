using MediatR;

namespace ShopManagement.Core.Contracts.Queries.ProductCategoryAgg
{
    public class GetProductCategories : IRequest<List<GetProductCategoriesResult>>
    {

    }
    public class GetProductCategoriesResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public long ProductsCount { get; set; }
    }
}
