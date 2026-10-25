using System.Text.Json;
using FiyatGor.Domain;
using Microsoft.EntityFrameworkCore;

namespace FiyatGor.Api;

public class DevDataSeeder
{
    private readonly AppDbContext _db;
    private readonly IWebHostEnvironment _env;

    public DevDataSeeder(AppDbContext db, IWebHostEnvironment env)
    {
        _db = db;
        _env = env;
    }

    public async Task SeedAsync()
    {
        if (await _db.Products.AnyAsync())
        {
            return;
        }

        var path = Path.Combine(_env.ContentRootPath, "Data", "products.json");
        var json = await File.ReadAllTextAsync(path);
        var products = JsonSerializer.Deserialize<List<Product>>(json, JsonSerializerOptions.Web) ?? [];

        _db.Products.AddRange(products);
        await _db.SaveChangesAsync();
    }
}
