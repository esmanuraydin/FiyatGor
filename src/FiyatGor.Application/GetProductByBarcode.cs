using FiyatGor.Domain;

namespace FiyatGor.Application;

public class GetProductByBarcode
{
    private readonly IProductSource _productSource;

    public GetProductByBarcode(IProductSource productSource)
    {
        _productSource = productSource;
    }

    public Task<Product?> ExecuteAsync(string barcode, CancellationToken ct)
    {
        return _productSource.GetByBarcodeAsync(barcode);
    }
}
