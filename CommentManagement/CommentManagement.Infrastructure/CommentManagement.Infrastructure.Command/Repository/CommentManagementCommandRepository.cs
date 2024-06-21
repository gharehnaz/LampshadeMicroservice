using CommentManagement.Core.Contracts.IRepositories.IComment;
using CommentManagement.Core.Domain.CommentAgg;

namespace CommentManagement.Infrastructure.Command.Repository
{
    public class CommentManagementCommandRepository : ICommentCommandRepository
    {
        public Task<long> Command(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
