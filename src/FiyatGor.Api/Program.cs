using FiyatGor.Application;
using FiyatGor.Domain;
using FiyatGor.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var seeder = new DevDataSeeder(db);
    await seeder.SeedAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.MapGet("/products/{barcode}", async Task<Results<Ok<Product>, NotFound>> (string barcode, GetProductByBarcode getProductByBarcode, CancellationToken ct) =>
{
    var product = await getProductByBarcode.ExecuteAsync(barcode, ct);
    return product is null ? TypedResults.NotFound() : TypedResults.Ok(product);
})
.WithName("GetProductByBarcode");

app.Run();
