using BlogManagement.Core.Domain.ArticleAgg;
using BlogManagement.Core.Domain.ArticleCategoryAgg;

namespace BlogManagement.Core.Contracts.IRepositories.IArticleCategory
{
    public interface IArticleCategoryCommandRepository
    {
        Task<long> Command(ArticleCategory article);

    }
}
