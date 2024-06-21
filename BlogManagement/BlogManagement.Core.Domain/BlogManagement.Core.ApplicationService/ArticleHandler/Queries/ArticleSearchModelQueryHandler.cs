using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Contracts.Queries.ArticleAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleHandler.Queries
{
    public class ArticleSearchModelQueryHandler:IRequestHandler<ArticleSearchModel, List<ArticleSearchModelResult>>
    {
        private readonly IArticleQueryRepository _repository;
        public ArticleSearchModelQueryHandler(IArticleQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ArticleSearchModelResult>> Handle(ArticleSearchModel request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }
}
