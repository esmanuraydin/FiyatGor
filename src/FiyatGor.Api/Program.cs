using FiyatGor.Api;
using FiyatGor.Shared;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<IProductSource, FakeProductSource>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/products/{barcode}", async Task<Results<Ok<Product>, NotFound>> (string barcode, IProductSource productSource) =>
{
    var product = await productSource.GetByBarcodeAsync(barcode);
    return product is null ? TypedResults.NotFound() : TypedResults.Ok(product);
})
.WithName("GetProductByBarcode");

app.Run();
