using MediatR;

namespace CommentManagement.Core.Contracts.Commands.CommentAgg
{
    public class CreateCommand:IRequest<CreateCommandResult>
    {
    }

    public class CreateCommandResult
    {
    }
}
