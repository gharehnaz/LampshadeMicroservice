using Microsoft.EntityFrameworkCore;
using ShopManagement.ApplicationService.OrderHandler.Commands;
using ShopManagement.ApplicationService.OrderHandler.Queries;
using ShopManagement.ApplicationService.ProductCategoriesHandler.Commands;
using ShopManagement.ApplicationService.ProductCategoriesHandler.Queries;
using ShopManagement.ApplicationService.ProductHandler.Commands;
using ShopManagement.ApplicationService.ProductHandler.Queries;
using ShopManagement.ApplicationService.ProductPictureHandler.Commands;
using ShopManagement.ApplicationService.ProductPictureHandler.Queries;
using ShopManagement.ApplicationService.SlideHandler.Commands;
using ShopManagement.ApplicationService.SlideHandler.Queries;
using ShopManagement.Configuration;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string cnn = builder.Configuration.GetConnectionString("Command_ConnectionString");
string cnnQuery = builder.Configuration.GetConnectionString("Query_ConnectionString");

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

ShopManagementCommandBootstrapper.Configure(builder.Services, cnn);
ShopManagementQueryBootstrapper.Configure(builder.Services, cnnQuery);




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
