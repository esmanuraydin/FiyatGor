using System.Text.Json;
using FiyatGor.Domain;
using Microsoft.EntityFrameworkCore;

namespace FiyatGor.Infrastructure;

public class DevDataSeeder
{
    private readonly AppDbContext _db;

    public DevDataSeeder(AppDbContext db)
    {
        _db = db;
    }

    public async Task SeedAsync()
    {
        if (await _db.Products.AnyAsync())
        {
            return;
        }

        var path = Path.Combine(AppContext.BaseDirectory, "Data", "products.json");
        var json = await File.ReadAllTextAsync(path);
        var products = JsonSerializer.Deserialize<List<Product>>(json, JsonSerializerOptions.Web) ?? [];

        _db.Products.AddRange(products);
        await _db.SaveChangesAsync();
    }
}