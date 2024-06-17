using BlogManagement.Core.Domain.ArticleAgg;

namespace BlogManagement.Core.Contracts.IRepositories.IArticleCategory
{
    public interface IArticleCategoryCommandRepository
    {
        Task<long> Command(Article article);

    }
}
