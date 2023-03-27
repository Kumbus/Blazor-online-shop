using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using ShopOnline.Application.Mappings;
using ShopOnline.Application.ServiceInterfaces;
using ShopOnline.Application.Services;
using ShopOnline.Domain.RepositoryInterfaces;
using ShopOnline.Infrastructure.Data;
using ShopOnline.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopOnlineConnection"));
});

builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
builder.Services.AddSingleton(AutoMapperConfig.Initialize());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy => policy.WithOrigins("https://localhost:7013", "https://localhost:7013/")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
