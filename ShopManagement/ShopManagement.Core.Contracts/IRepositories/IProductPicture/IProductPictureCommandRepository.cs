using ShopManagement.Core.Domain.ProductPictureAgg.Entities;

namespace ShopManagement.Core.Contracts.IRepositories.IProductPicture
{
    public interface IProductPictureCommandRepository
    {
        Task<long> Command(ProductPicture productPicture);

    }
}
