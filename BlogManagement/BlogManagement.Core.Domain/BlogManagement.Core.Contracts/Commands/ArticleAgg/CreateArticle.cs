using MediatR;

namespace BlogManagement.Core.Contracts.Commands.ArticleAgg
{
    public class CreateArticle:IRequest<CreateArticleResult>
    {
    }

    public class CreateArticleResult
    {
    }
}
