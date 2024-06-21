using BlogManagement.Core.Contracts.IRepositories.IArticle;
using BlogManagement.Core.Contracts.IRepositories.IArticleCategory;
using BlogManagement.Infrastructure.Command.Repository;
using Microsoft.Extensions.DependencyInjection;
using BlogManagement.Infrastructure.Query;
using Microsoft.EntityFrameworkCore;
using BlogManagement.Infrastructure.Query.Repository;

namespace BlogManagement.Configuration
{
    public class BlogManagementQueryBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryQueryRepository, ArticleCategoryQueryRepository>();
            services.AddTransient<IArticleQueryRepository, ArticleQueryRepository>();

            services.AddDbContext<BlogManagementQueryDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
