using BlogManagement.Core.Domain.ArticleAgg;
using BlogManagement.Core.Domain.ArticleCategoryAgg;
using BlogManagement.Infrastructure.Command.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Infrastructure.Command
{
    public class BlogManagementCommandDbContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public BlogManagementCommandDbContext(DbContextOptions<BlogManagementCommandDbContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
