# Karar Defteri (ADR)

> ADR = Architecture Decision Record. Her kalıcı kararın "ne, neden, alternatifler" kaydı.
> Yeni karar en alta eklenir; eski kararlar silinmez, gerekirse "Yerini aldı: ADR-00X" diye işaretlenir.

## Şablon
```
## ADR-00X: <Karar başlığı>
- Tarih:
- Durum: Önerildi / Kabul edildi / Yerini aldı
- Bağlam: Hangi sorunu çözüyoruz?
- Seçenekler: A / B / (C)
- Karar:
- Gerekçe:
- Sonuçları: Neyi kolaylaştırıyor, neyin bedelini ödüyoruz?
```

---

## ADR-001: Ürün verisi IProductSource arayüzünün arkasında
- Tarih: 2026-10-19
- Durum: Kabul edildi
- Bağlam: Mikro'daki ürün/fiyat verisine hangi yolla ve izinle erişileceği belli değil, ama geliştirmenin beklememesi gerekiyor.
- Seçenekler: A) Mikro erişimini bekle · B) Doğrudan veritabanına bağlan · C) Veri kaynağını bir arayüzün arkasına sakla
- Karar: C. Önce `FakeProductSource` (JSON), sonra `MikroProductSource`.
- Gerekçe: API ve mobil uygulama veri kaynağından bağımsız gelişir. Mikro geldiğinde sadece yeni bir sınıf eklenir.
- Sonuçları: Ekstra bir soyutlama katmanı oluşur. Sahte verinin gerçek veriyle aynı şekilde olmasına dikkat etmek gerekir.

## ADR-002: Projects ve Claude Code iş bölümü
- Tarih: 2026-10-24
- Durum: Kabul edildi
- Bağlam: Başta Esma kodu kendisi yazıyor, Claude ipucu veriyordu. Esma, ürünü daha hızlı çıkarmak ve araç pratiği kazanmak için akışı değiştirmek istedi.
- Seçenekler: A) Claude Code kodu yazar, Esma onaylar · B) Projects sohbetinde Claude yazar, Esma yapıştırır · C) Esma yazar, Claude ipucu verir
- Karar: A. Claude Code terminalde yazar, Projects sohbeti açıklar ve soru sorar.
- Gerekçe: Terminalde Claude Code ile çalışmak hedeflenen yetkinliğin parçası. Projects sohbeti Esma'nın dosyalarına erişemiyor. Her yazma izni Esma'nın onayından geçiyor.
- Sonuçları: Hız artar. Anlamak için "geri anlat" adımı kalır. İzin istemleri okunmalı, commit'leri Esma atar. CLAUDE.md talimatları zorlayıcı değil.

## ADR-003: Hedef framework .NET 10
- Tarih: 2026-10-19
- Durum: Kabul edildi
- Bağlam: Brifte ".NET 8+" yazıyordu. Kurulu SDK 10.0.401. .NET 8 desteği 2026-11-10'da bitiyor (doğrulanmadı).
- Seçenekler: A) .NET 8 · B) .NET 10
- Karar: B (.NET 10). Tüm projeler `net10.0` hedefler.
- Gerekçe: İkisi de LTS sürümüdür; ancak .NET 8 desteğinin yakında bitme riski bulunurken bilgisayarda halihazırda .NET 10 SDK (10.0.401) kuruludur.
- Sonuçları: Destek 2028-11'e kadar sürer (doğrulanmadı). İnternetteki örneklerin bir kısmı .NET 8 ile yazılmış olabilir. Brif ".NET 10" olarak güncellenmeli.
