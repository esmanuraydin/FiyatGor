# FiyatGör

El terminalinde barkod okutunca fiyat gösteren demo. Sahibi Esma. İki hedef eşit: çalışan ürün ve Esma'nın AI araçlarını öğrenmesi.

## Teknoloji
- .NET 10 (net10.0), C#, ASP.NET Core Minimal API
- Çözüm: FiyatGor.slnx. Projeler: src\FiyatGor.Api ve src\FiyatGor.Shared
- Ürün verisi IProductSource arkasında (ADR-001). FakeProductSource, src\FiyatGor.Api\Data\products.json dosyasını okur
- Fiyatlar decimal, barkod string

## Komutlar
- Derle: dotnet build
- Çalıştır: dotnet run --project src\FiyatGor.Api

## Kurallar
- Kod, sınıf ve metot adları, commit mesajları İngilizce. Açıklamalar ve konuşma Türkçe.
- Commit mesajı biçimi: Conventional Commits (feat, fix, docs, chore).
- git add, commit ve push komutlarını çalıştırma. Esma kendisi çalıştırır. Hangi komutu neden önerdiğini söyle.
- Bir dosya yazmadan önce ne yapacağını ve nedenini Türkçe kısaca anlat. Yazdıktan sonra dosyayı satır satır özetle.
- Küçük adımlarla ilerle: bir seferde bir dosya ya da bir değişiklik.
- Önemli tasarım kararlarında en az iki seçenek ve bir öneri sun. Karar Esma'nın.
- Kararlar docs\karar-defteri.md içinde. Brif: docs\fiyatgor-proje-brifi.md.
