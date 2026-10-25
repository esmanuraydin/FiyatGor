using FiyatGor.Domain;
using Microsoft.EntityFrameworkCore;

namespace FiyatGor.Api;

public class DbProductSource : IProductSource
{
    private readonly AppDbContext _db;

    public DbProductSource(AppDbContext db)
    {
        _db = db;
    }

    public Task<Product?> GetByBarcodeAsync(string barcode)
    {
        return _db.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Barcode == barcode);
    }
}
