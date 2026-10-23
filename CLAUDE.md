# FiyatGör

El terminalinde barkod okutunca fiyat gösteren demo. Sahibi Esma. İki hedef eşit: çalışan ürün ve Esma'nın AI araçlarını öğrenmesi. Bir adım işi hızlandırıp öğrenmeyi atlatıyorsa öğrenme kazanır.

## Mevcut durum
- Faz 0 kapandı. Sıradaki: Faz 1, yani `GET /products/{barcode}`, FakeProductSource ve OpenAPI.
- Program.cs hâlâ şablondaki /weatherforecast uç noktasını içeriyor. FakeProductSource henüz DI'a kayıtlı değil.
- Test projesi yok.

## Teknoloji
- .NET 10 (net10.0, ADR-003), C#, ASP.NET Core Minimal API
- Çözüm: FiyatGor.slnx. Projeler: src\FiyatGor.Api ve src\FiyatGor.Shared (ortak modeller). Planlanan: FiyatGor.Mobile (.NET MAUI Android)
- Ürün verisi IProductSource arkasında (ADR-001): `Task<Product?> GetByBarcodeAsync(string barcode)`. Mikro erişimi netleşince MikroProductSource eklenecek
- FakeProductSource, src\FiyatGor.Api\Data\products.json dosyasını okur. JSON alanları camelCase (`JsonSerializerOptions.Web`)
- Product, FiyatGor.Shared içinde bir record. Alan eklenir ya da değişirse products.json da aynı adımda güncellenir
- Fiyatlar decimal, barkod string

## Komutlar
- Derle: dotnet build
- Çalıştır: dotnet run --project src\FiyatGor.Api

## Çalışma biçimi (ADR-002)
- Claude Code kodu yazar, Esma her yazma iznini onaylar. Projects sohbeti açıklama ve soru içindir.
- Bir dosya yazmadan önce ne yapacağını ve nedenini Türkçe kısaca anlat. Yazdıktan sonra dosyayı satır satır özetle.
- Esma yazılanı kendi cümleleriyle geri anlatır. Yanlış ya da eksik anladığı yeri düzelt.
- Küçük adımlarla ilerle: bir seferde bir dosya ya da bir değişiklik.
- Önemli tasarım kararlarında en az iki seçenek ve bir öneri sun. Karar Esma'nın. Daha iyi bir yol görürsen açıkça söyle.
- Kalıcı kararlar docs\karar-defteri.md içine ADR olarak, şablona uygun biçimde en alta eklenir. Eski kararlar silinmez, gerekirse "Yerini aldı" diye işaretlenir.

## Git
- git add, commit ve push komutlarını çalıştırma. Esma kendisi çalıştırır. Hangi komutu neden önerdiğini söyle.
- Commit mesajı biçimi: Conventional Commits (feat, fix, docs, chore).
- Her adım ayrı commit'lenebilecek büyüklükte olsun ki eski hâle dönmek kolay olsun.

## Dil
- Kod, sınıf ve metot adları, commit mesajları İngilizce. Açıklamalar ve konuşma Türkçe.

## Belgeler
- docs\fiyatgor-proje-brifi.md: proje brifi
- docs\karar-defteri.md: kararlar (ADR)
- docs\calisma-sozlesmesi.md: roller ve ritim. Roller tablosu ADR-002'den önce yazıldı, çelişkide ADR-002 geçerli
- README.md: yol haritası ve hedef mimari
