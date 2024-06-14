using MediatR;
using ShopManagement.Core.Contracts.Commands.ProductPictureAgg;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Core.Contracts.Queries.ProductPictureAgg
{
    public class GetProductPictureDetails:IRequest<GetProductPictureDetailsResult>
    {
        public long Id { get; set; }

    }
    public class GetProductPictureDetailsResult
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
