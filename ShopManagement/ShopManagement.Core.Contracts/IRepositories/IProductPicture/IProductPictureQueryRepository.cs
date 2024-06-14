using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.Core.Contracts.IRepositories.IProductPicture
{
    public interface IProductPictureQueryRepository
    {
        Task<GetProductPictureResult> Query(GetProductPicture getProductPicture);
        Task<GetWithProductAndCategoryResult> Query(GetWithProductAndCategory getWithProductAndCategory);
        Task<List<ProductPictureSearchResult>> Query(ProductPictureSearch searchModel);
    }
}
