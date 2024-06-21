using BlogManagement.Core.Contracts.Commands.ArticleCategoryAgg;
using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Core.Domain.ArticleCategoryAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleCategoryHandler.Commands
{
    public class CreateArticleCategoryCommandHandler : IRequestHandler<CreateArticleCategory, CreateArticleCategoryResult>
    {
        private readonly IArticleCategoryCommandRepository _repository;
        public CreateArticleCategoryCommandHandler(IArticleCategoryCommandRepository repository)
        {
            _repository = repository;
        }
        public async Task<CreateArticleCategoryResult> Handle(CreateArticleCategory request, CancellationToken cancellationToken)
        {
            var articleCategory = new ArticleCategory(request.Name, request.Picture, request.PictureAlt, request.PictureTitle,
            request.Description, request.ShowOrder, request.Slug, request.Keywords, request.MetaDescription,
            request.CanonicalAddress);
            await _repository.Command(articleCategory);
            var result = new CreateArticleCategoryResult
            {
                Id = articleCategory.Id
            };
            return result;
        }
    }
}
