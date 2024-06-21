using CommentManagement.Core.Contracts.IRepositories.IComment;
using CommentManagement.Infrastructure.Command;
using CommentManagement.Infrastructure.Command.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CommentManagement.Configuration
{
    public class CommentManagementCommandBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICommentCommandRepository, CommentManagementCommandRepository>();

            services.AddDbContext<CommentManagementCommandDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
