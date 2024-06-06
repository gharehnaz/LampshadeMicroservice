using MediatR;

namespace ShopManagement.Core.Contracts.Commands.ProductCategoryAgg
{
    public class CreateProductCategory : IRequest<CreateProductCategoryResult>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }
    }
    public class CreateProductCategoryResult
    {
        public long ProductCategoryId { get; set; }
    }
}
