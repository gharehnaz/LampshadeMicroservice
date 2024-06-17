using CommentManagement.Core.Domain.CommentAgg;

namespace CommentManagement.Core.Contracts.IRepositories.IComment
{
    public interface ICommentCommandRepository
    {
        Task<long> Command(Comment comment);

    }
}
