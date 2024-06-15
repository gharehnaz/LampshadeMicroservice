namespace ProductPictureAgg.Infrastructure.Queries.Common
{
    public class ProductPicture
    {
        public long ProductId { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public bool IsRemoved { get; set; }
        public Product Product { get; set; }
        public long Id { get; internal set; }

    }
}