using Microsoft.EntityFrameworkCore;
using ProductCategoryAgg.Infrastructure.Commands;
using ProductCategoryAgg.Infrastructure.Queries;
using ShopManagement.ApplicationService.ProductCategoriesHandler.Commands;
using ShopManagement.Core.Contracts.IRepositories.IProductCategory;
using System.Net.NetworkInformation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductCategoryCommandRepository, ProductCategoryCommandRepository>();

string cnn = builder.Configuration.GetConnectionString("ProductCategoryCommand_ConnectionString");
string cnnQuery = builder.Configuration.GetConnectionString("ProductCategoryQuery_ConnectionString");
builder.Services.AddDbContext<ProductCategoryCommandDbContext>(c => c.UseSqlServer(cnn));

builder.Services.AddDbContext<ProductCategoryQueryDbContext>(c => c.UseSqlServer(cnnQuery));

builder.Services.AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(typeof(CreateProductCategoryHandler).Assembly));
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
