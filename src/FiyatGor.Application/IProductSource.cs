using FiyatGor.Domain;

namespace FiyatGor.Application;

public interface IProductSource
{
    Task<Product?> GetByBarcodeAsync(string barcode);
}