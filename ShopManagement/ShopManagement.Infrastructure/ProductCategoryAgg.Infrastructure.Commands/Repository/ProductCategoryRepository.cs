using ShopManagement.Core.Contracts.Commands.ProductCategoryAgg;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Domain.ProductCategoryAgg.Entities;

namespace ProductCategoryAgg.Infrastructure.Commands.Repository
{
    public class ProductCategoryCommandRepository : IProductCategoryCommandRepository
    {
        private readonly ProductCategoryCommandDbContext _context;
        public ProductCategoryCommandRepository(ProductCategoryCommandDbContext context)
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
