using Microsoft.EntityFrameworkCore;
using OrderAgg.Infrastructure.Commands;
using OrderAgg.Infrastructure.Commands.Repository;
using OrderAgg.Infrastructure.Queries;
using OrderAgg.Infrastructure.Queries.Repository;
using ProductAgg.Infrastructure.Commands;
using ProductAgg.Infrastructure.Commands.Repository;
using ProductAgg.Infrastructure.Queries;
using ProductAgg.Infrastructure.Queries.Repository;
using ProductCategoryAgg.Infrastructure.Commands;
using ProductCategoryAgg.Infrastructure.Commands.Repository;
using ProductCategoryAgg.Infrastructure.Queries;
using ProductPictureAgg.Infrastructure.Commands;
using ProductPictureAgg.Infrastructure.Commands.Repository;
using ProductPictureAgg.Infrastructure.Queries;
using ProductPictureAgg.Infrastructure.Queries.Repository;
using ShopManagement.ApplicationService.OrderHandler.Commands;
using ShopManagement.ApplicationService.OrderHandler.Queries;
using ShopManagement.ApplicationService.ProductCategoriesHandler;
using ShopManagement.ApplicationService.ProductCategoriesHandler.Commands;
using ShopManagement.ApplicationService.ProductCategoriesHandler.Queries;
using ShopManagement.ApplicationService.ProductHandler.Commands;
using ShopManagement.ApplicationService.ProductHandler.Queries;
using ShopManagement.ApplicationService.ProductPictureHandler.Commands;
using ShopManagement.ApplicationService.ProductPictureHandler.Queries;
using ShopManagement.ApplicationService.SlideHandler.Commands;
using ShopManagement.ApplicationService.SlideHandler.Queries;
using ShopManagement.Core.Contracts.IRepositories.IOrder;
using ShopManagement.Core.Contracts.IRepositories.IProduct;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using ShopManagement.Core.Contracts.IRepositories.IProductPicture;
using ShopManagement.Core.Contracts.IRepositories.ISlide;
using SlideAgg.Infrastructure.Commands;
using SlideAgg.Infrastructure.Commands.Repository;
using SlideAgg.Infrastructure.Queries;
using SlideAgg.Infrastructure.Queries.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string cnn = builder.Configuration.GetConnectionString("ProductCategoryCommand_ConnectionString");
string cnnQuery = builder.Configuration.GetConnectionString("ProductCategoryQuery_ConnectionString");

//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddMediatR(cfg =>
{
cfg.RegisterServicesFromAssembly(typeof(CreateProductCategoryHandler).Assembly);
cfg.RegisterServicesFromAssembly(typeof(GetDetailsHandler).Assembly);
cfg.RegisterServicesFromAssembly(typeof(GetProductCategoriesHandler).Assembly);
cfg.RegisterServicesFromAssembly(typeof(ProductCategorySearchHandler).Assembly);

    cfg.RegisterServicesFromAssembly(typeof(CreateProductCommandHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetProductDetailsQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetProductsQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetProductWithCategoryQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(ProductSearchQueryHandler).Assembly);

    cfg.RegisterServicesFromAssembly(typeof(CreateOrderCommandHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetAmountByQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetOrderItemQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(OrderSearchQueryHandler).Assembly);

    cfg.RegisterServicesFromAssembly(typeof(CreateProductPictureCommandHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetWithProductAndCategoryQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetProductPictureDetailsQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(ProductPictureSearchQueryHandler).Assembly);

    cfg.RegisterServicesFromAssembly(typeof(CreateSlideCommandHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetSlideDetailsQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetSlidesQueryHandler).Assembly);


});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddDbContext<ProductCategoryCommandDbContext>(c => c.UseSqlServer(cnn));
builder.Services.AddDbContext<ProductCategoryQueryDbContext>(c => c.UseSqlServer(cnnQuery));

builder.Services.AddDbContext<ProductCommandDbContext>(c => c.UseSqlServer(cnn));
builder.Services.AddDbContext<ProductQueryDbContext>(c => c.UseSqlServer(cnnQuery));

builder.Services.AddDbContext<OrderCommandDbContext>(c => c.UseSqlServer(cnn));
builder.Services.AddDbContext<OrderQueryDbContext>(c => c.UseSqlServer(cnnQuery));

builder.Services.AddDbContext<ProductPictureCommandDbContext>(c => c.UseSqlServer(cnn));
builder.Services.AddDbContext<ProductPictureQueryDbContext>(c => c.UseSqlServer(cnnQuery));

builder.Services.AddDbContext<SlideCommandDbContext>(c => c.UseSqlServer(cnn));
builder.Services.AddDbContext<SlideQueryDbContext>(c => c.UseSqlServer(cnnQuery));

builder.Services.AddScoped<IProductCategoryQueryRepository, ProductCategoryQueryRepository>();
builder.Services.AddScoped<IProductCategoryCommandRepository, ProductCategoryCommandRepository>();

builder.Services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddScoped<IProductCommandRepository, ProductCommandRepository>();

builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();
builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepsitory>();

builder.Services.AddScoped<IProductPictureQueryRepository, ProductPictureQueryRepository>();
builder.Services.AddScoped<IProductPictureCommandRepository, ProductPictureCommandRepository>();


builder.Services.AddScoped<ISlideQueryRepository, SlideQueryRepository>();
builder.Services.AddScoped<ISlideCommandRepository, SlideCommandRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
