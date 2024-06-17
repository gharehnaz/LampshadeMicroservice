using MediatR;

namespace BlogManagement.Core.Contracts.Queries.ArticleCategoryAgg
{
    public class GetArticleCategories:IRequest<GetArticleCategoriesResult>
    {
    }

    public class GetArticleCategoriesResult
    {
    }
}