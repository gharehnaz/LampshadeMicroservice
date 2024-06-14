using MediatR;

namespace ShopManagement.Core.Contracts.Queries.SlideAgg
{
    public class GetSlideDetails:IRequest<GetSlideDetailsResult>
    {
        public long Id { get; set; }
    }
    public class GetSlideDetailsResult
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Heading { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string BtnText { get; set; }
        public string Link { get; set; }

    }
}
