using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Contracts.Queries.ArticleAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleHandler.Queries
{
    public class GetDetailsArticleQueryHandler:IRequestHandler<GetDetailsArticle, GetDetailsArticleResult>
    {
        private readonly IArticleQueryRepository _repository;
        public GetDetailsArticleQueryHandler(IArticleQueryRepository repository)
        {
            _repository = repository;  
        }

        public async Task<GetDetailsArticleResult> Handle(GetDetailsArticle request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }
}
