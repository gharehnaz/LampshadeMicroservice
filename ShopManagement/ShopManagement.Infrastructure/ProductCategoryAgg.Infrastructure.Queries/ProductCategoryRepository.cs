using Microsoft.EntityFrameworkCore;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.Queries.ProductCategoryAgg;

namespace ProductCategoryAgg.Infrastructure.Queries
{
    public class ProductCategoryRepository: IProductCategoryQueryRepository
    {
        private readonly ProductCategoryQueryDbContext _context;
        public ProductCategoryRepository(ProductCategoryQueryDbContext context) 
        {
            _context = context;
        }


        

        public GetDetailsResult Query(GetDetails getDetails)
        {
            return _context.ProductCategories.Select(x => new GetDetailsResult()
            {
                Id = x.Id,
                Description = x.Description,
                Name = x.Name,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                //Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug
            }).FirstOrDefault(x => x.Id == getDetails.Id);
        }

        public List<GetProductCategoriesResult> Query(GetProductCategories getProductCategories)
        {
            return _context.ProductCategories.Select(x => new GetProductCategoriesResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public List<ProductCategorySearchResult> Query(ProductCategorySearch searchModel)
        {
            var query = _context.ProductCategories.Select(x => new ProductCategorySearchResult
            {
                Id = x.Id,
                Picture = x.Picture,
                Name = x.Name,
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            return query.OrderByDescending(x => x.Id).ToList();
        }

    }
}
