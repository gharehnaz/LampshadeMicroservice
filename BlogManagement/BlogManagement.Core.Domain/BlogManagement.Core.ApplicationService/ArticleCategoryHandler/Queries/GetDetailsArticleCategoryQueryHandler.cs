using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleCategoryHandler.Queries
{
    public class GetDetailsArticleCategoryQueryHandler:IRequestHandler<GetDetailsArticleCategory, GetDetailsArticleCategoryResult>
    {
        private readonly IArticleCategoryQueryRepository _repository;
        public GetDetailsArticleCategoryQueryHandler(IArticleCategoryQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetDetailsArticleCategoryResult> Handle(GetDetailsArticleCategory request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
