using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ShopManagement.Core.Contracts.IRepositories.IProductPicture
{
    public interface IProductPictureQueryRepository
    {
        Task<GetProductPictureDetailsResult> Query(GetProductPictureDetails getProductPictureDetails);
        Task<GetWithProductAndCategoryResult> Query(GetWithProductAndCategory getWithProductAndCategory);
        Task<List<ProductPictureSearchResult>> Query(ProductPictureSearch searchModel);
    }
}
