using MediatR;

namespace CommentManagement.Core.Contracts.Commands.CommentAgg
{
    public class CreateComment:IRequest<CreateCommentResult>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Website { get; set; }
        public long OwnerRecordId { get; set; }
        public int Type { get; set; }
        public long ParentId { get; set; }
    }

    public class CreateCommentResult
    {
        public long Id { get; set; }
    }
}
