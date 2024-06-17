using BlogManagement.Core.Domain.ArticleAgg;

namespace BlogManagement.Core.Contracts.IRepositories.IArticle
{
    public interface IArticleCommandRepository
    {
        Task<long> Command(Article order);

    }
}
