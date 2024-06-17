using MediatR;

namespace CommentManagement.Core.Contracts.Queries.CommentAgg
{
    public class CommentSearchModel:IRequest<CommentSearchModelResult>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class CommentSearchModelResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Message { get; set; }
        public long OwnerRecordId { get; set; }
        public string OwnerName { get; set; }
        public int Type { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsCanceled { get; set; }
        public string CommentDate { get; set; }
    }
}