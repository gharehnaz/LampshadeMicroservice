using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Infrastructure_.Repository;
using ShopManagement.Infrastructure_;

namespace ShopManagement.Configuration
{
    public class ShopManagementQueryBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IProductCategoryQueryRepository, ProductCategoryQueryRepository>();

            services.AddTransient<IProductQueryRepository, ProductQueryRepository>();

            services.AddTransient<IOrderQueryRepository, OrderQueryRepository>();

            services.AddTransient<IProductPictureQueryRepository, ProductPictureQueryRepository>();

            services.AddTransient<ISlideQueryRepository, SlideQueryRepository>();

            services.AddDbContext<ShopManagementQueryDbContext>(x => x.UseSqlServer(connectionString));

        }

    }
}
