using MediatR;

namespace CommentManagement.Core.Contracts.Queries.CommentAgg
{
    public class CommentSearchModel:IRequest<CommentSearchModelResult>
    {
    }

    public class CommentSearchModelResult
    {
    }
}