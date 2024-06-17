using BlogManagement.Core.Contracts.Queries.ArticleAgg;
using BlogManagement.Core.Domain.ArticleAgg;

namespace BlogManagement.Core.Contracts.IRepositories.IArticle
{
    public interface IArticleQueryRepository
    {
        Task<GetDetailsArticleResult> Query(GetDetailsArticle getDetailsArticle);
        Task<GetWithCategoryResult> Query(GetWithCategory getWithCategory);
        Task<List<ArticleSearchModelReult>> Query(ArticleSearchModel searchModel);
    }
}
