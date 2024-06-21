using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleCategoryHandler.Queries
{
    public class ArticleCategorySearchModelQueryHandler : IRequestHandler<ArticleCategorySearchModel, List<ArticleCategorySearchModelResult>>
    {
        private readonly IArticleCategoryQueryRepository _repository;
        public ArticleCategorySearchModelQueryHandler(IArticleCategoryQueryRepository repository)
        {
            _repository= repository;
        }

        public async Task<List<ArticleCategorySearchModelResult>> Handle(ArticleCategorySearchModel request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
