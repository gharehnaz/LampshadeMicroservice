using ShopManagement.Core.Contracts.Commands.ProductCategoryAgg;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;

namespace ProductCategoryAgg.Infrastructure.Commands
{
    public class ProductCategoryCommandRepository : IProductCategoryCommandRepository
    {
        private readonly ProductCategoryCommandDbContext _context;
        public ProductCategoryCommandRepository(ProductCategoryCommandDbContext context)
        {
            _context = context;
        }
        public async Task<long> Command(CreateProductCategory createProductCategory)
        {
            var res=await _context.ProductCategories.Add(createProductCategory.Id,);
            _context.SaveChangesAsync();
            return createProductCategory.Id;
         
        }
    }
}
