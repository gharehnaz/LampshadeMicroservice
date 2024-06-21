using CommentManagement.Core.Domain.CommentAgg;
using CommentManagement.Infrastructure.Command.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CommentManagement.Infrastructure.Command
{
    public class CommentManagementCommandDbContext:DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public CommentManagementCommandDbContext(DbContextOptions<CommentManagementCommandDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(CommentMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
