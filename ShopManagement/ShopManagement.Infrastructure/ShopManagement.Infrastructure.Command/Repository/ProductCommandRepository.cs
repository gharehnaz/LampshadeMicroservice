using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Domain.ProductAgg.Entities;

namespace ShopManagement.Infrastructure.Command.Repository
{
    public class ProductCommandRepository : IProductCommandRepository
    {
        private readonly ShopManagementCommandDbContext _context;
        public ProductCommandRepository(ShopManagementCommandDbContext context)
        {
            _context = context;
        }
        public async Task<long> Command(Product product)
        {
            await _context.AddAsync(product);

            await _context.SaveChangesAsync();
            return product.Id;
        }
    }
}
