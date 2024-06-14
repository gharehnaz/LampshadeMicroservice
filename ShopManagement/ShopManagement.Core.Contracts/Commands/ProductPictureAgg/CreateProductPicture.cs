using MediatR;

namespace ShopManagement.Core.Contracts.Commands.ProductPictureAgg
{
    public class CreateProductPicture:IRequest<CreateProductPictureResult>
    {
        public long ProductId { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public long CategoryId { get; set; }
        public string CreationDate { get; set; }
    }
    public class CreateProductPictureResult 
    {
        public long Id { get; set; }
    }
}
