using CommentManagement.Core.Contracts.Commands.CommentAgg;
using CommentManagement.Core.Contracts.IRepositories.IComment;
using CommentManagement.Core.Domain.CommentAgg;
using MediatR;
using System.Xml.Linq;

namespace CommentManagement.Core.ApplicationService.CommentHandler.Commands
{
    public class CreateCommentHandler : IRequestHandler<CreateComment, CreateCommentResult>
    {
        private readonly ICommentCommandRepository _repository;
        public async Task<CreateCommentResult> Handle(CreateComment request, CancellationToken cancellationToken)
        {
            var comment = new Comment(request.Name, request.Email, request.Website, request.Message, request.OwnerRecordId, request.Type, request.ParentId);
            await _repository.Command(comment);
            var result = new CreateCommentResult
            {
                Id = comment.Id
            };


            return result;
        }
    }
}
