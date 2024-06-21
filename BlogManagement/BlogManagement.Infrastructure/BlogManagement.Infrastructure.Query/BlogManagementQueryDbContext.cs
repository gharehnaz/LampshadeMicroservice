using BlogManagement.Core.Domain.ArticleAgg;
using BlogManagement.Core.Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Infrastructure.Query
{
    public class BlogManagementQueryDbContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public BlogManagementQueryDbContext(DbContextOptions<BlogManagementQueryDbContext>options):base(options)
        {
            
        }
    }
}
