using MediatR;
using ShopManagement.Core.Contracts.Commands.ProductCategoryAgg;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Domain.ProductCategoryAgg.Entities;

namespace ShopManagement.ApplicationService.ProductCategoriesHandler.Commands
{
    public class CreateProductCategoryHandler : IRequestHandler<CreateProductCategory, CreateProductCategoryResult>
    {
        private readonly IProductCategoryCommandRepository _repository;
        public CreateProductCategoryHandler(IProductCategoryCommandRepository repository)
        {
            _repository = repository;     
        }

        public async Task<CreateProductCategoryResult> Handle(CreateProductCategory request, CancellationToken cancellationToken)
        {
            var productCategory = new ProductCategory(request.Name, request.Description,
                request.Picture, request.PictureAlt, request.PictureTitle, request.Keywords,
                request.MetaDescription, request.Slug);
            await _repository.Command(productCategory);
            var result =  new CreateProductCategoryResult
            {
                ProductCategoryId = productCategory.Id
            };


            return result;

        }
    }
}
