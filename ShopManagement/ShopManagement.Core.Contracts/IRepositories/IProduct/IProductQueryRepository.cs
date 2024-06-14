using ShopManagement.Core.Contracts.Queries.ProductAgg;

namespace ShopManagement.Core.Contracts.IRepositories.IProduct
{
    public interface IProductQueryRepository
    {
        Task<GetProductDetailsResult> Query(GetProductDetails getProductDetails);
        Task<List<GetProductsResult>> Query(GetProducts getProducts);
        Task<List<ProductSearchResult>> Query(ProductSearch searchModel);
        Task<GetProductWithCategoryResult> Query(GetProductWithCategory getProductWithCategory);
    }
}
