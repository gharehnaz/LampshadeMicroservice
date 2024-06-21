using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Infrastructure.Command;
using BlogManagement.Infrastructure.Command.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogManagement.Configuration
{
    public class BlogManagementCommandBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryCommandRepository, ArticleCategoryCommandRepository>();
            services.AddTransient<IArticleCommandRepository, ArticleCommandRepository>();

            services.AddDbContext<BlogManagementCommandDbContext>(x => x.UseSqlServer(connectionString));
        }

    }
}
