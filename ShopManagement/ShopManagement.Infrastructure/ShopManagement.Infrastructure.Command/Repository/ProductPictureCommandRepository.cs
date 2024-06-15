using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Domain.ProductPictureAgg.Entities;

namespace ShopManagement.Infrastructure.Command.Repository
{
    public class ProductPictureCommandRepository : IProductPictureCommandRepository
    {
        private readonly ShopManagementCommandDbContext _context;

        public ProductPictureCommandRepository(ShopManagementCommandDbContext context)
        {
            _context = context;
        }
        public async Task<long> Command(ProductPicture productPicture)
        {
            await _context.AddAsync(productPicture);

            await _context.SaveChangesAsync();
            return productPicture.Id;
        }
    }
}
