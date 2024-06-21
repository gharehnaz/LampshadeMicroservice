using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Contracts.Queries.ArticleAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleHandler.Queries
{
    public class GetWithCategoryQueryHandler:IRequestHandler<GetWithCategory, GetWithCategoryResult>
    {
        private readonly IArticleQueryRepository _repository;
        public GetWithCategoryQueryHandler(IArticleQueryRepository repository)
        {
            _repository = repository;  
        }

        public async Task<GetWithCategoryResult> Handle(GetWithCategory request, CancellationToken cancellationToken)
        {
            var query = await _repository.Query(request);
            return query;
        }
    }
}
