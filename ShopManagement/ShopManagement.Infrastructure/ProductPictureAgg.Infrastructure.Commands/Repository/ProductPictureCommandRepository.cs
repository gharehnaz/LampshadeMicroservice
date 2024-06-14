using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Domain.OrderAgg.Entities;
using ShopManagement.Core.Domain.ProductPictureAgg.Entities;

namespace ProductPictureAgg.Infrastructure.Commands.Repository
{
    public class ProductPictureCommandRepository : IProductPictureCommandRepository
    {
        private readonly ProductPictureCommandDbContext _context;

        public ProductPictureCommandRepository(ProductPictureCommandDbContext context)
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
