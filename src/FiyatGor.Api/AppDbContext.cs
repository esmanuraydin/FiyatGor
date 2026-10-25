using FiyatGor.Domain;
using Microsoft.EntityFrameworkCore;

namespace FiyatGor.Api;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(product =>
        {
            product.ToTable("products");
            product.HasKey(p => p.Barcode);

            product.Property(p => p.Barcode).HasMaxLength(32);
            product.Property(p => p.Name).HasMaxLength(200);
            product.Property(p => p.Brand).HasMaxLength(100);
            product.Property(p => p.Size).HasMaxLength(50);
            product.Property(p => p.UnitPriceUnit).HasMaxLength(20);
            product.Property(p => p.CampaignText).HasMaxLength(200);
            product.Property(p => p.Sku).HasMaxLength(50);

            product.Property(p => p.Price).HasColumnType("decimal(10,2)");
            product.Property(p => p.UnitPrice).HasColumnType("decimal(10,2)");
            product.Property(p => p.CampaignPrice).HasColumnType("decimal(10,2)");
        });
    }
}
