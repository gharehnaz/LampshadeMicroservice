using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Contracts.Queries.ArticleAgg;

namespace BlogManagement.Infrastructure.Query.Repository
{
    public class ArticleQueryRepository : IArticleQueryRepository
    {
        public Task<GetDetailsArticleResult> Query(GetDetailsArticle getDetailsArticle)
        {
            throw new NotImplementedException();
        }

        public Task<GetWithCategoryResult> Query(GetWithCategory getWithCategory)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleSearchModelResult>> Query(ArticleSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
