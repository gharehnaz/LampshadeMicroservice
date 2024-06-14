using MediatR;
using ShopManagement.Core.Contracts.Commands.ProductPictureAgg;
using ShopManagement.Core.Contracts.Commands.SlideAgg;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Core.Domain.ProductPictureAgg.Entities;
using ShopManagement.Core.Domain.SlideAgg.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace ShopManagement.ApplicationService.SlideHandler.Commands
{
    public class CreateSlideCommandHandler : IRequestHandler<CreateSlide, CreateSlideResult>
    {
        private readonly ISlideCommandRepository _repository;
        public CreateSlideCommandHandler(ISlideCommandRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateSlideResult> Handle(CreateSlide request, CancellationToken cancellationToken)
        {
            var slide = new Slide(request.Picture, request.PictureAlt, request.PictureTitle, request.Heading,
            request.Title, request.Text, request.Link, request.BtnText);
            await _repository.Command(slide);
            var result = new CreateSlideResult
            {
                Id = slide.Id
            };


            return result;
        }
    }

}
