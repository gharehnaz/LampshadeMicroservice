using CommentManagement.Core.Contracts.IRepositories.IComment;
using CommentManagement.Core.Contracts.Queries.CommentAgg;
using MediatR;

namespace CommentManagement.Core.ApplicationService.CommentHandler.Queries
{
    public class CommentSearchModelQueryHandler : IRequestHandler<CommentSearchModel, List<CommentSearchModelResult>>
    {
        private readonly ICommentQueryRepository _repository;
        public CommentSearchModelQueryHandler(ICommentQueryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<CommentSearchModelResult>> Handle(CommentSearchModel request, CancellationToken cancellationToken)
        {
            return await _repository.Query(request);
        }
    }
}
