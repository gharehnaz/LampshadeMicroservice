using ShopManagement.Core.Domain.ProductCategoryAgg.Entities;

namespace ShopManagement.Core.Contracts.IRepositories.IProductCategory
{
    public interface IProductCategoryCommandRepository
    {
       Task<long> Command(ProductCategory ProductCategory);
    }
}
