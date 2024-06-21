using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg;

namespace BlogManagement.Infrastructure.Query.Repository
{
    public class ArticleCategoryQueryRepository : IArticleCategoryQueryRepository
    {
        public Task<GetSlugByResult> Query(GetSlugBy getSlugBy)
        {
            throw new NotImplementedException();
        }

        public Task<GetDetailsArticleCategoryResult> Query(GetDetailsArticleCategory getDetailsArticleCategory)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetArticleCategoriesResult>> Query(GetArticleCategories getArticleCategories)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleCategorySearchModelResult>> Query(ArticleCategorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
