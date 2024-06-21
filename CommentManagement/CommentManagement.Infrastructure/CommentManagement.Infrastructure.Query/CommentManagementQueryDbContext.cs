using CommentManagement.Core.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace CommentManagement.Infrastructure.Query
{

    public class CommentManagementQueryDbContext:DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public CommentManagementQueryDbContext(DbContextOptions<CommentManagementQueryDbContext> options) : base(options)
        {

        }
    }
}
