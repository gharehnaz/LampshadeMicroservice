using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.Queries.ProductAgg;

namespace ShopManagement.Infrastructure_.Repository
{
    public class ProductQueryRepository : IProductQueryRepository
    {
        private readonly ShopManagementQueryDbContext _context;
        public ProductQueryRepository(ShopManagementQueryDbContext context)
        {
            _context = context;
        }
        public async Task<GetProductDetailsResult> Query(GetProductDetails getProductDetails)
        {
            return _context.Products.Select(x => new GetProductDetailsResult
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Slug = x.Slug,
                CategoryId = x.CategoryId,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
            }).FirstOrDefault(x => x.Id == getProductDetails.Id);
        }

        public async Task<List<GetProductsResult>> Query(GetProducts getProducts)
        {
            return _context.Products.Select(x => new GetProductsResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public async Task<List<ProductSearchResult>> Query(ProductSearch searchModel)
        {
            var query = _context.Products
                           .Include(x => x.Category)
                           .Select(x => new ProductSearchResult
                           {
                               Id = x.Id,
                               Name = x.Name,
                               Category = x.Category.Name,
                               CategoryId = x.CategoryId,
                               Code = x.Code,
                               Picture = x.Picture,
                           });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.Code))
                query = query.Where(x => x.Code.Contains(searchModel.Code));

            if (searchModel.CategoryId != 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public async Task<GetProductWithCategoryResult> Query(GetProductWithCategory getProductWithCategory)
        {
            var result = _context.Products.Include(x => x.Category).Select(x => new GetProductWithCategoryResult
            {
                Name = x.Name


            }).FirstOrDefault(x => x.Id == getProductWithCategory.Id);

            return result;
        }
    }
}
