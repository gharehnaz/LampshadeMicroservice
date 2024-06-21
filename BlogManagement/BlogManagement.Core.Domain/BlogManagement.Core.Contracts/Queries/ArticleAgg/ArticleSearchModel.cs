using MediatR;

namespace BlogManagement.Core.Contracts.Queries.ArticleAgg
{
    public class ArticleSearchModel:IRequest<List<ArticleSearchModelResult>>
    {
        public string Title { get; set; }
        public long CategoryId { get; set; }
    }

    public class ArticleSearchModelResult
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Picture { get; set; }
        public string PublishDate { get; set; }
        public string Category { get; set; }
        public long CategoryId { get; set; }
    }
}