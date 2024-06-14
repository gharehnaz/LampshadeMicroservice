using MediatR;
using ShopManagement.Core.Contracts.Commands.ProductAgg;
using ShopManagement.Core.Contracts.Commands.ProductPictureAgg;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Domain.ProductAgg.Entities;
using ShopManagement.Core.Domain.ProductPictureAgg.Entities;

namespace ShopManagement.ApplicationService.ProductPictureHandler.Commands
{
    public class CreateProductPictureCommandHandler : IRequestHandler<CreateProductPicture, CreateProductPictureResult>
    {
        private readonly IProductPictureCommandRepository _repository;
        public CreateProductPictureCommandHandler(IProductPictureCommandRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateProductPictureResult> Handle(CreateProductPicture request, CancellationToken cancellationToken)
        {
            var productPicture = new ProductPicture(request.ProductId, request.Picture, request.PictureAlt, request.PictureTitle);
            await _repository.Command(productPicture);
            var result = new CreateProductPictureResult
            {
                Id = productPicture.Id
            };


            return result;
        }
    }

}
