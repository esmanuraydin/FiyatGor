using FiyatGor.Api;
using FiyatGor.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IProductSource, DbProductSource>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var seeder = new DevDataSeeder(db, app.Environment);
    await seeder.SeedAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.MapGet("/products/{barcode}", async Task<Results<Ok<Product>, NotFound>> (string barcode, IProductSource productSource) =>
{
    var product = await productSource.GetByBarcodeAsync(barcode);
    return product is null ? TypedResults.NotFound() : TypedResults.Ok(product);
})
.WithName("GetProductByBarcode");

app.Run();
