using System.Text.Json;
using FiyatGor.Application;
using FiyatGor.Domain;

namespace FiyatGor.Api;

public class FakeProductSource : IProductSource
{
    private readonly List<Product> _products;

    public FakeProductSource(IWebHostEnvironment env)
    {
        var path = Path.Combine(env.ContentRootPath, "Data", "products.json");
        var json = File.ReadAllText(path);
        _products = JsonSerializer.Deserialize<List<Product>>(json, JsonSerializerOptions.Web) ?? [];
    }

    public Task<Product?> GetByBarcodeAsync(string barcode)
    {
        var product = _products.FirstOrDefault(p => p.Barcode == barcode);
        return Task.FromResult(product);
    }
}