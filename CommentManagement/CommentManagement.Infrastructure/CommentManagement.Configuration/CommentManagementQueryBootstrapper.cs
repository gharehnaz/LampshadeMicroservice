using CommentManagement.Core.Contracts.IRepositories.IComment;
using CommentManagement.Infrastructure.Command;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CommentManagement.Infrastructure.Query.Repository;

namespace CommentManagement.Configuration
{
    public class CommentManagementQueryBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICommentQueryRepository, CommentManagementQueryRepository>();

            services.AddDbContext<CommentManagementCommandDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
