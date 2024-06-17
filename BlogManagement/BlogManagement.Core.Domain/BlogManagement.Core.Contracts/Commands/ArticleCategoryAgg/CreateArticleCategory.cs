using MediatR;

namespace BlogManagement.Core.Contracts.Commands.ArticleCategoryAgg
{
    public class CreateArticleCategory:IRequest<CreateArticleCategoryResult>
    {
    }

    public class CreateArticleCategoryResult
    {
    }
}
