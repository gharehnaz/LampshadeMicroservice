using MediatR;
using ShopManagement.Core.Contracts.Commands.ProductAgg;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Core.Contracts.Queries.ProductAgg
{
    public class GetProductDetails : IRequest<GetProductDetailsResult>
    {
        public long Id { get; set; }
    }
    public class GetProductDetailsResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public long CategoryId { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public List<ProductCategoryViewModel> Categories { get; set; }
    }
}
