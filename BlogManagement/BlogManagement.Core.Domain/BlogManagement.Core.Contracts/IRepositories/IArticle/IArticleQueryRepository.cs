using BlogManagement.Core.Contracts.Queries.ArticleAgg;

namespace BlogManagement.Core.Contracts.IRepositories.IArticle
{
    public interface IArticleQueryRepository
    {
        Task<GetDetailsArticleResult> Query(GetDetailsArticle getDetailsArticle);
        Task<GetWithCategoryResult> Query(GetWithCategory getWithCategory);
        Task<List<ArticleSearchModelResult>> Query(ArticleSearchModel searchModel);
    }
}
