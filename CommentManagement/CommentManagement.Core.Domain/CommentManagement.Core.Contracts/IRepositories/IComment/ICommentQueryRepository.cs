using CommentManagement.Core.Contracts.Queries.CommentAgg;

namespace CommentManagement.Core.Contracts.IRepositories.IComment
{
    public interface ICommentQueryRepository
    {
        Task<List<CommentSearchModelResult>> Query(CommentSearchModel searchModel);

    }
}
