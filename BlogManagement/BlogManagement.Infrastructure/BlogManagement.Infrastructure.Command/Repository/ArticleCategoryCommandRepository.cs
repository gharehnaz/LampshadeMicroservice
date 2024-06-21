using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Core.Domain.ArticleCategoryAgg;

namespace BlogManagement.Infrastructure.Command.Repository
{
    public class ArticleCategoryCommandRepository : IArticleCategoryCommandRepository
    {
        public Task<long> Command(ArticleCategory article)
        {
            throw new NotImplementedException();
        }
    }
}
