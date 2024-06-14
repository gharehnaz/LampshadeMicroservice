namespace ShopManagement.Core.Contracts.IRepositories.IProduct
{
    public interface IProductQueryRepository
    {
        Task<GetProductResult> Query(GetProduct getProduct);
        Task<List<GetProductsResult>> Query(GetProducts getProducts);
        Task<List<ProductSearchResult>> Query(ProductSearch searchModel);
        Task<GetProductWithCategoryResult> Query(GetProductWithCategory getProductWithCategory);
    }
}
