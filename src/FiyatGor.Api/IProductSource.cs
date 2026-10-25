using FiyatGor.Domain;

namespace FiyatGor.Api;

public interface IProductSource
{
    Task<Product?> GetByBarcodeAsync(string barcode);
}