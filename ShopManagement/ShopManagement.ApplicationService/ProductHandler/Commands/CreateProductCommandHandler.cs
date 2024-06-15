using MediatR;
using ShopManagement.Core.Contracts.Commands.ProductAgg;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Domain.ProductAgg.Entities;

namespace ShopManagement.ApplicationService.ProductHandler.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProduct, CreateProductResult>
    {
        private readonly IProductCommandRepository _repository;
        public CreateProductCommandHandler(IProductCommandRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateProductResult> Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Code, request.ShortDescription, request.Description,
            request.Picture, request.PictureAlt, request.PictureTitle, request.CategoryId, request.Slug,
            request.Keywords, request.MetaDescription);
            await _repository.Command(product);
            var result = new CreateProductResult
            {
                Id = product.Id
            };


            return result;
        }
    }

}
