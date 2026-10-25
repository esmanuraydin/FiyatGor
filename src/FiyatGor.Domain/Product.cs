namespace FiyatGor.Domain;

public record Product(
    string Barcode,
    string Name,
    string Brand,
    string Size,
    decimal Price,
    decimal UnitPrice,
    string UnitPriceUnit,
    decimal? CampaignPrice,
    string? CampaignText,
    int VatRate,
    string Sku,
    int StockQuantity);
