using MediatR;

namespace BlogManagement.Core.Contracts.Queries.ArticleAgg
{
    public class ArticleSearchModel:IRequest<ArticleSearchModelResult>
    {
    }

    public class ArticleSearchModelResult
    {
    }
}