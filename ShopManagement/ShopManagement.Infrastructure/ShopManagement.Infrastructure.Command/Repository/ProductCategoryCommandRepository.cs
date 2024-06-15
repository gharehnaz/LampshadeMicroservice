using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Domain.ProductCategoryAgg.Entities;

namespace ShopManagement.Infrastructure.Command.Repository
{
    public class ProductCategoryCommandRepository : IProductCategoryCommandRepository
    {
        private readonly ShopManagementCommandDbContext _context;
        public ProductCategoryCommandRepository(ShopManagementCommandDbContext context)
        {
            _context = context;
        }
        public async Task<long> Command(ProductCategory productCategory)
        {
            await _context.AddAsync(productCategory);

            await _context.SaveChangesAsync();
            return productCategory.Id;

        }
    }
}
