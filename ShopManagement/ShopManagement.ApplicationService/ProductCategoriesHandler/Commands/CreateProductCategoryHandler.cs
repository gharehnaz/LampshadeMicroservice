using MediatR;
using ShopManagement.Core.Contracts.Commands.ProductCategoryAgg;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;

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
            var result = _repository.Command(request);

            var response= new CreateProductCategoryResult
            {
                ProductCategoryId = request.Id
            };
            return response;

        }
    }
}
