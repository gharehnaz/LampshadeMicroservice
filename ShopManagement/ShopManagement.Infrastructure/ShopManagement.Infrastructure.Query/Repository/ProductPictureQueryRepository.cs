using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.Queries.ProductPictureAgg;

namespace ShopManagement.Infrastructure_.Repository
{
    public class ProductPictureQueryRepository : IProductPictureQueryRepository
    {
        private readonly ShopManagementQueryDbContext _context;
        public ProductPictureQueryRepository(ShopManagementQueryDbContext context)
        {

            _context = context;

        }
        public async Task<GetProductPictureDetailsResult> Query(GetProductPictureDetails getProductPictureDetails)
        {
            return _context.ProductPictures
                           .Select(x => new GetProductPictureDetailsResult
                           {
                               Id = x.Id,
                               PictureAlt = x.PictureAlt,
                               PictureTitle = x.PictureTitle,
                               ProductId = x.ProductId
                           }).FirstOrDefault(x => x.Id == getProductPictureDetails.Id);
        }

        public async Task<GetWithProductAndCategoryResult> Query(GetWithProductAndCategory getWithProductAndCategory)
        {
            var result = _context.ProductPictures
                           .Include(x => x.Product)
                           .ThenInclude(x => x.Category).
                           Select(x => new GetWithProductAndCategoryResult
                           {
                               Picture = x.Picture,
                           })
                           .FirstOrDefault(x => x.Id == getWithProductAndCategory.Id);
            return result;
        }

        public async Task<List<ProductPictureSearchResult>> Query(ProductPictureSearch searchModel)
        {
            var query = _context.ProductPictures
                            .Include(x => x.Product)
                            .Select(x => new ProductPictureSearchResult
                            {
                                Id = x.Id,
                                Product = x.Product.Name,
                                Picture = x.Picture,
                                ProductId = x.ProductId,
                                IsRemoved = x.IsRemoved
                            });

            if (searchModel.ProductId != 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
