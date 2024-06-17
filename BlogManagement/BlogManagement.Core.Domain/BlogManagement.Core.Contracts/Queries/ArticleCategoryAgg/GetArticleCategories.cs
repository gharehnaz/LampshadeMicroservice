using MediatR;

namespace BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg
{
    public class GetArticleCategories:IRequest<GetArticleCategoriesResult>
    {
    }

    public class GetArticleCategoriesResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int ShowOrder { get; set; }
        public string CreationDate { get; set; }
        public long ArticlesCount { get; set; }
    }
}