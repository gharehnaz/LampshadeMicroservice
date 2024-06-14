using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Domain.OrderAgg.Entities;
using ShopManagement.Core.Domain.ProductAgg.Entities;

namespace ProductAgg.Infrastructure.Commands.Repository
{
    public class ProductCommandRepository : IProductCommandRepository
    {
        private readonly ProductCommandDbContext _context;
        public ProductCommandRepository(ProductCommandDbContext context)
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
