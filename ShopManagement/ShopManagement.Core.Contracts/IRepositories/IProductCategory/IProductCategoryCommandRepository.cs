using ShopManagement.Core.Contracts.Commands.ProductCategoryAgg;

namespace ShopManagement.Core.Contracts.IRepositories.IProductCategory
{
    public interface IProductCategoryCommandRepository
    {
       Task<long> Command(CreateProductCategory createProductCategory);
    }
}
