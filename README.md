# FiyatGör

FiyatGör, Mikro ERP'deki “Fiyat Gör” özelliğinin orta ölçekli bir demo kopyasıdır. Bursa'daki market çalışanları ve yöneticileri için Android el terminallerinde barkodla ürün fiyatı sorgulamayı hedefler. Proje, Else Teknoloji tarafında doğan bir ihtiyaçtan yola çıkmıştır; Mikro bağlantısı ileride değerlendirilecektir.

Bu çalışma için belirlenmiş bir teslim tarihi yoktur. Öncelik öğrenmek ve çalışan bir demo ortaya çıkarmaktır.

## Hedeflenen özellikler

- Barkod okutulduğunda ürün adı, fiyat ve kampanya bilgisini gösterme
- Stok miktarını görüntüleme
- Etiket üretme ve basma
- Demo düzeyinde kasa işlevleri
- Ürün ve fiyat yönetimi için, canlı demosu Vercel'de yayınlanacak yönetici web paneli

İlk anlamlı demo, el terminalinde barkod okutulduğunda ürün fiyatının görüntülenmesidir.

## Hedef mimari

```text
[El terminali: .NET MAUI Android] ──HTTP──► [ASP.NET Core Web API] ──► [PostgreSQL]
                                                  │
                                           IProductSource
                                     ├─ FakeProductSource (products.json)
                                     └─ MikroProductSource (erişim netleşince)
```

Mikro verisine hangi yolla ve hangi izinlerle erişilebileceği henüz net değildir. Bu nedenle veri kaynağı, uygulamanın geri kalanından `IProductSource` arayüzüyle ayrılacaktır. İlk aşamada sahte ürün verisi kullanılacaktır.

Planlanan solution projeleri:

- `FiyatGor.Api` — ASP.NET Core Minimal API
- `FiyatGor.Mobile` — .NET MAUI Android uygulaması
- `FiyatGor.Shared` — ortak modeller ve sözleşmeler

## Teknolojiler

- C# ve .NET 10
- ASP.NET Core Minimal API
- Entity Framework Core
- PostgreSQL (yerel geliştirme için Docker)
- .NET MAUI (Android)
- Git ve GitHub

## Geliştirme ortamı

Proje Windows üzerinde geliştirilmektedir. Hedeflenen araçlar: VS Code, Antigravity IDE, Claude Code ve Docker Desktop.

Proje hazırlık aşamasındadır; uygulama projeleri ve çalıştırma adımları henüz oluşturulmamıştır.

## Yol haritası

| Faz | Kapsam | Durum |
|---|---|---|
| 0 | Depo, solution, README, `.gitignore` ve `CLAUDE.md` hazırlığı | Devam ediyor |
| 1 | `GET /products/{barcode}`, `FakeProductSource` ve Swagger | Planlandı |
| 2 | Docker'da PostgreSQL, EF Core ve migration | Planlandı |
| 3 | MAUI uygulamasında barkod alanı ve ürün kartı | Planlandı |
| 4 | El terminali tarayıcısıyla barkod okutma | Planlandı |
| 5 | Stok ve basit rol/yetki | Planlandı |
| 6 | Etiket üretimi ve basımı | Planlandı |
| 7 | Demo kasa | Planlandı |
| 8 | Mikro entegrasyonu (adapter) | Planlandı |

## Açık konular

- El terminalinin marka/modeli ve Android sürümü
- Mikro verisine erişim yöntemi ve gerekli izinler
- Canlı ortamda veritabanının Supabase'te tutulup tutulmayacağı ve API'nin nerede barındırılacağı
- Yönetici web panelinde kullanılacak teknoloji

Proje kararları ve güncel faz bilgisi için [`docs/`](./docs/) içindeki belgeleri inceleyin.
