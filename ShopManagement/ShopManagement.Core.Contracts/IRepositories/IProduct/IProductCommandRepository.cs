using ShopManagement.Core.Domain.ProductAgg.Entities;

namespace ShopManagement.Core.Contracts.IRepositories.IProduct
{
    public interface IProductCommandRepository
    {
        Task<long> Command(Product ProductCategory);

    }
}
