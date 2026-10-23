# FiyatGör — Proje Brifi

> Bu dosya proje bilgi bankasının "tek doğru kaynağı"dır. Her faz sonunda güncellenir.
> Son güncelleme: 2026-10-19 · Aktif faz: 0 (Hazırlık)

## Ne yapıyoruz?
Mikro ERP'deki "Fiyat Gör" özelliğinin orta ölçekli bir demo kopyası.
Taskora nasıl Jira'nın küçük bir demosuysa, FiyatGör de onun gibi.

- **Kullanıcılar:** Bursa'daki marketlerin çalışanları ve yöneticileri
- **Cihaz:** Android tabanlı el terminalleri (demo için cihazlar mevcut)
- **Bağlam:** Proje Else Teknoloji tarafında (Mikro bayi) bir ihtiyaçtan doğdu, ileride Else'ye bağlanacak
- **Teslim tarihi:** Yok. Öncelik öğrenmek ve çalışan bir demo çıkarmak

## Kapsam
1. Fiyat görme: barkod okut → ürün adı, fiyat, kampanya
2. Stok miktarı
3. Etiket basımı
4. Demo düzeyinde kasa
5. Yönetici web paneli: ürün/fiyat yönetimi; Vercel'de yayınlanan canlı demo yüzü (karar: 2026-10-19)

## Mimari
```
[El terminali: .NET MAUI Android] ──HTTP──► [ASP.NET Core Web API] ──► [PostgreSQL]
                                                  │
                                           IProductSource
                                     ├─ FakeProductSource (products.json)
                                     └─ MikroProductSource (erişim netleşince)
```
- Mikro verisine hangi yolla ve izinle erişileceği belirsiz. Bu yüzden veri kaynağı bir arayüzün arkasında.
- Solution yapısı: `FiyatGor.Api`, `FiyatGor.Mobile`, `FiyatGor.Shared`

## Teknoloji
C# / .NET 10, ASP.NET Core Minimal API, EF Core, PostgreSQL (lokalde Docker), .NET MAUI (Android), Git + GitHub.
Geliştirme ortamı: Windows, VS Code, Antigravity IDE, Claude Code, Docker Desktop.

## Fazlar
| Faz | İş | Durum |
|---|---|---|
| 0 | Repo, solution, README, .gitignore, CLAUDE.md | ⏳ |
| 1 | `GET /products/{barcode}` + FakeProductSource + Swagger | — |
| 2 | Docker'da PostgreSQL + EF Core + migration | — |
| 3 | MAUI uygulaması: barkod kutusu + ürün kartı | — |
| 4 | El terminali tarayıcısıyla barkod okutma | — |
| 5 | Stok + basit rol/yetki | — |
| 6 | Etiket üretimi/basımı | — |
| 7 | Demo kasa | — |
| 8 | Mikro entegrasyonu (adapter) | — |

İlk anlamlı demo: 3. ve 4. fazların sonu, yani el terminalinde barkod okutup fiyat görmek.

## Açık sorular
- El terminali marka/model ve Android sürümü?
- Mikro verisine erişim yolu ve izni?
- Canlıya alma: veritabanı Supabase'de mi olacak? API nerede barınacak?
- Yönetici web paneli hangi teknolojiyle yazılacak? (Faz 5 civarı karar)

## Ortam
- Claude Pro plan · GitHub hesabı mevcut (repo henüz açılmadı)
