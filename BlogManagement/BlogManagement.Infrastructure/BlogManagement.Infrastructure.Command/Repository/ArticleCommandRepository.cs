using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Domain.ArticleAgg;

namespace BlogManagement.Infrastructure.Command.Repository
{
    public class ArticleCommandRepository : IArticleCommandRepository
    {
        public Task<long> Command(Article order)
        {
            throw new NotImplementedException();
        }
    }
}
