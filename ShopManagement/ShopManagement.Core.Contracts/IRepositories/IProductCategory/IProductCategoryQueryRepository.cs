using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.Core.Contracts.IRepositories.IProductCategory
{
    public interface IProductCategoryQueryRepository
    {
        GetDetailsResult Query(GetDetails getDetails);
        Task<List<GetProductCategoriesResult>> Query(GetProductCategories getProductCategories);
        Task<List<ProductCategorySearchResult>> Query(ProductCategorySearch searchModel);
    }
}
