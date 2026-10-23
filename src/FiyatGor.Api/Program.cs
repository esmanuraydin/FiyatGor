using FiyatGor.Api;

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

app.MapGet("/products/{barcode}", async (string barcode, IProductSource productSource) =>
{
    var product = await productSource.GetByBarcodeAsync(barcode);
    return product is null ? Results.NotFound() : Results.Ok(product);
})
.WithName("GetProductByBarcode");

app.Run();
