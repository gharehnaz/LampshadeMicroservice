using CommentManagement.Core.Contracts.IRepositories.IComment;
using CommentManagement.Core.Contracts.Queries.CommentAgg;

namespace CommentManagement.Infrastructure.Query.Repository
{
    public class CommentManagementQueryRepository : ICommentQueryRepository
    {
        public Task<List<CommentSearchModelResult>> Query(CommentSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
