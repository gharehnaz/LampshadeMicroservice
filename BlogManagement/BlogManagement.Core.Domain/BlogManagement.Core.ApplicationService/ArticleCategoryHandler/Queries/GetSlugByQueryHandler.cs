using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleCategoryHandler.Queries
{
    public class GetSlugByQueryHandler:IRequestHandler<GetSlugBy, GetSlugByResult>
    {
        private readonly IArticleCategoryQueryRepository _repository;
        public GetSlugByQueryHandler(IArticleCategoryQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetSlugByResult> Handle(GetSlugBy request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
