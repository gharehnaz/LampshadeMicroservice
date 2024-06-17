using MediatR;

namespace BlogManagement.Core.Contracts.Queries.ArticleAgg
{
    public class GetWithCategory:IRequest<GetWithCategoryResult>
    {
    }

    public class GetWithCategoryResult
    {
    }
}