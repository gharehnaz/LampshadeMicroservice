using Microsoft.EntityFrameworkCore;
using ProductCategoryAgg.Infrastructure.Commands;
using ProductCategoryAgg.Infrastructure.Commands.Repository;
using ProductCategoryAgg.Infrastructure.Queries;
using ShopManagement.ApplicationService.ProductCategoriesHandler;
using ShopManagement.ApplicationService.ProductCategoriesHandler.Commands;
using ShopManagement.ApplicationService.ProductCategoriesHandler.Queries;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;


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


});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

builder.Services.AddDbContext<ProductCategoryCommandDbContext>(c => c.UseSqlServer(cnn));
builder.Services.AddDbContext<ProductCategoryQueryDbContext>(c => c.UseSqlServer(cnnQuery));


builder.Services.AddScoped<IProductCategoryQueryRepository, ProductCategoryQueryRepository>();
builder.Services.AddScoped<IProductCategoryCommandRepository, ProductCategoryCommandRepository>();


var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperConfigs());
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


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
