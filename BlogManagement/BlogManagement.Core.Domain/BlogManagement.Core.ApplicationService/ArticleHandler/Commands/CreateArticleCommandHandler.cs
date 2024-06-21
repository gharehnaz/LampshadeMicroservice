using BlogManagement.Core.Contracts.Commands.ArticleAgg;
using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Domain.ArticleAgg;
using MediatR;

namespace BlogManagement.Core.ApplicationService.ArticleHandler.Commands
{
    public class CreateArticleCommandHandler:IRequestHandler<CreateArticle, CreateArticleResult>
    {
        private readonly IArticleCommandRepository _repository;
        public CreateArticleCommandHandler(IArticleCommandRepository repository)
        {
            _repository = repository;
        }
        public async Task<CreateArticleResult> Handle(CreateArticle request, CancellationToken cancellationToken)
        {
            var article = new Article(request.Title, request.ShortDescription, request.Description, request.Picture,
            request.PictureAlt,request.PictureTitle, request.PublishDate, request.Slug, request.Keywords, request.MetaDescription,
            request.CanonicalAddress,request.CategoryId);
            await _repository.Command(article);
            var result = new CreateArticleResult
            {
                Id = article.Id
            };
            return result;
        }
    }
}
