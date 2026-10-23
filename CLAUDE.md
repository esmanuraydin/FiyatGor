# FiyatGör

El terminalinde barkod okutunca fiyat gösteren demo. Sahibi Esma. İki hedef eşit: çalışan ürün ve Esma'nın AI araçlarını öğrenmesi. Bir adım işi hızlandırıp öğrenmeyi atlatıyorsa öğrenme kazanır.

## Mevcut durum
- Faz 0 kapandı. Faz 1 devam ediyor: `GET /products/{barcode}`, FakeProductSource ve OpenAPI.
- FakeProductSource, Program.cs içinde IProductSource olarak AddSingleton ile kayıtlı. `GET /products/{barcode}` ucu var: ürün bulunursa 200 ve ürünü, bulunamazsa 404 döner.
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
- Esma yazılanı kendi cümleleriyle geri anlatır. Yanlış ya da eksik anladığı yeri düzelt.
- Küçük adımlarla ilerle: bir seferde bir dosya ya da bir değişiklik.
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

## Çıktı kuralları
- Sadece istenen işi yap. Ek dosya, ek öneri, alternatif ya da yan görev ekleme.
- Cevabın en fazla 6 satır olsun: ne yaptığını söyle, değişen dosyaları listele.
- Soru sorma. Yalnızca işi sürdüremeyecek kadar belirsizsen sor.
- Commit mesajı önerme. Bir sonraki adımı önerme. Bunları Esma, Projects sohbetinden alır.
- Açıklama ve tasarım kararı Projects sohbetinin işidir. Esma'ya "şunu sohbette sor" de.
