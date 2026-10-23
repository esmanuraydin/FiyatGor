# Çalışma Sözleşmesi — Esma & Claude

> FiyatGör'ü iki ortak gibi yürütüyoruz. Bu dosya kimin neyi yaptığını ve kararları nasıl aldığımızı tanımlar.

## İki hedef, eşit ağırlıkta
1. FiyatGör'ü çalışan, başkalarına gösterilebilir bir ürüne dönüştürmek.
2. Esma'nın yapay zekâ araçlarını ve modern geliştirme ekosistemini uçtan uca, profesyonel düzeyde kullanabilir hale gelmesi.

Bir adım projeyi hızlandırıyor ama öğrenmeyi atlatıyorsa, öğrenme kazanır.

## Roller
| | Esma | Claude |
|---|---|---|
| Klavye | Her yazma iznini okur, onaylar ya da reddeder | Kodu Claude Code ile terminalde yazar (ADR-002) |
| Kararlar | Son söz Esma'da | Seçenekleri ve artı/eksilerini sunar, bir öneride bulunur, gerekçesini söyler |
| Git | Komutları Esma çalıştırır | Hangi komutun neden kullanılacağını söyler |
| Config dosyaları | Değişikliği okur ve onaylar | Yazar, her ayarın ne işe yaradığını anlatır |
| Projects sohbeti | Anlamadığını sorar | Açıklar ve soru sorar, dosya yazmaz |
| İtiraz | — | Daha iyi bir yol görürse açıkça söyler, "evet efendim" demez |

## Dosya yazma ritüeli
1. **Anla:** Claude, dosyanın ne işe yaradığını, sistemde nerede durduğunu ve ne yazacağını kısaca anlatır.
2. **Yaz ve onayla:** Claude Code yazar. Esma izin istemini okur, onaylar ya da reddeder.
3. **Özet:** Claude yazdığı dosyayı satır satır özetler.
4. **Geri anlatım:** Esma kendi cümleleriyle açıklar, Claude yanlışları düzeltir.

## Karar alma
- Her önemli kararda Claude en az 2 seçenek ve bir öneri sunar.
- Kalıcı kararlar `karar-defteri.md`'ye ADR olarak yazılır.

## Dil
- Sohbet Türkçe.
- Kod, sınıf/metot adları ve commit mesajları İngilizce.
- Commit stili: Conventional Commits (`feat:`, `fix:`, `docs:`, `chore:`).

## Ritim
- Her adım commit'lenir. Deneme süreci olduğu için her an eski yönteme dönülebilmeli.
- Her oturum sonunda `docs/ogrenme-gunlugu.md`'ye kısa not: ne öğrendim, hangi aracı kullandım, neyi anlamadım.
- Her faz sonunda bu bilgi bankasındaki brif güncellenir.

## Araç öğrenme kuralı
Her fazda en az bir yeni araç ya da özellik deneyimlenir. Araç yalnızca projeye gerçek bir fayda sağlıyorsa eklenir; gösteriş için araç eklenmez.
