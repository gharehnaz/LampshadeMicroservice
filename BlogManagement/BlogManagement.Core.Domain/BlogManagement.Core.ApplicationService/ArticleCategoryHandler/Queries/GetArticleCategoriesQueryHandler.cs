using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleCategoryHandler.Queries
{
    public class GetArticleCategoriesQueryHandler:IRequestHandler<GetArticleCategories, List<GetArticleCategoriesResult>>
    {
        private readonly IArticleCategoryQueryRepository _repository;
        public GetArticleCategoriesQueryHandler(IArticleCategoryQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetArticleCategoriesResult>> Handle(GetArticleCategories request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
