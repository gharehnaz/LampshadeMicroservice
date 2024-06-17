using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.IRepositories.ISlide;
using ShopManagement.Infrastructure.Command;
using ShopManagement.Infrastructure.Command.Repository;


namespace ShopManagement.Configuration
{
    public class ShopManagementCommandBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IProductCategoryCommandRepository, ProductCategoryCommandRepository>();

            services.AddTransient<IProductCommandRepository, ProductCommandRepository>();

            services.AddTransient<IOrderCommandRepository, OrderCommandRepsitory>();

            services.AddTransient<IProductPictureCommandRepository, ProductPictureCommandRepository>();

            services.AddTransient<ISlideCommandRepository, SlideCommandRepository>();

            services.AddDbContext<ShopManagementCommandDbContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
