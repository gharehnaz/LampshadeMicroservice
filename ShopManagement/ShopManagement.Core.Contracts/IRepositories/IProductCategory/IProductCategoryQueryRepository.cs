using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.Core.Contracts.IRepositories.IProductCategory
{
    public interface IProductCategoryQueryRepository
    {
        GetDetailsResult Query(GetDetails getDetails);
        List<GetProductCategoriesResult> Query(GetProductCategories getProductCategories);
        List<ProductCategorySearchResult> Query(ProductCategorySearch searchModel);
    }
}
