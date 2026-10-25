
Öğrenme Defteri: 22-24 Ekim 2026
Faz 0 kapanışı ve Faz 1 (ürün ucu) başlangıcı. Sohbetimiz ve senin yapıştırdığın Claude Code terminal kayıtları birleştirildi.

0. Bu defter hakkında
Kaynaklar: Proje sohbetimiz (Claude Projects) ve senin yapıştırdığın Claude Code terminal kayıtları.
Tarihler yerel saatine göre (Türkiye, UTC+3). Gece yarısını geçince tarih değişiyor: 1. oturum 22 Ekim akşamı başlayıp 23 Ekim sabaha karşı bitti, 2. oturum 24 Ekim'de gece yarısından sonra yapıldı.
İşaretler:
"(doğrulanmadı)" = Resmi dokümandan okumadım, genel bilgiye dayanıyor.
"(senin beyanın)" = Çıktısını ben görmedim, senin söylediğine dayanıyor.
"(Claude Code'un raporu)" = Terminal kaydında Claude Code böyle yazdı, ben bağımsız olarak çalıştırıp doğrulamadım.
Commit mesajları: Aşağıdaki mesajlar bizim önerdiklerimiz ve Claude Code'un önerdikleri. Gerçekte atılanları görmek için git log --oneline yaz.
1. Şu anki durum (özet)
Faz 0 kapandı: repo GitHub'da (senin beyanın), ADR-003 (.NET 10) yazıldı, README ve brif .NET 10'a güncellendi.
Claude Code kuruldu (PATH sorununu çözdün), ilk görevi repoyu açıklamaktı.
Faz 1'in çekirdeği çalışıyor: GET /products/{barcode} ürün varsa 200 ve JSON, yoksa 404 döndürüyor.
Çalışma düzeni değişti: ADR-002 ile kodu terminaldeki Claude Code yazıyor, sen her izni okuyup onaylıyorsun.
Mimari zincir: tarayıcı → MapGet ucu → IProductSource → FakeProductSource → products.json.
2. Zaman çizelgesi
1. oturum: 22 Ekim akşamı - 23 Ekim sabaha karşı
Faz 0 kapanışı: Karar defterine ADR-003, briften ".NET 8+" ifadesinin kalkması, öğrenme günlüğü, yeni araç olarak Claude Code önerildi.
Claude Code kurulumu: PowerShell'de irm https://claude.ai/install.ps1 | iex. Sonra claude --version "komut tanınmıyor" hatası verdi. Nedeni PATH'ti (bölüm 6). VS Code'u kapatıp açınca ve PATH düzeltilince çözüldü.
İlk görev: claude yazıp Claude.ai hesabıyla girdin, repoyu açıklamasını istedin. Yazma iznini de verdiğini söyledin. git status temiz çıktı (hiçbir dosya değişmedi).
Karar defteri: ADR-003'ü sen yazdın. Tarih düzeltmesi: yerel saatle gece yarısı geçtiği için 19 Ekim doğruydu (ben yazım hatası sanmıştım).
Faz 1 planı: dotnet new webapi .NET 10'da Minimal API üretiyor. OpenAPI belgesi hazır geliyor, ama tıklanabilir Swagger arayüzü hazır gelmiyor.
Program.cs şablonunu okudun: summaries dizisi, Enumerable.Range, Random.Shared.Next, TemperatureF (bölüm 5).
Product alanları: 12 alan belirledin. Kararlar: fiyat decimal, kapsam B (hepsi şimdi).
Product.cs: Shared projesinde record olarak yazıldı.
Proje referansı: Api projesi Shared'ı tanıdı.
IProductSource: Api projesinde duruyor (A seçeneği).
FakeProductSource ve products.json: ADR-001'e uygun olarak veri JSON'dan okunuyor (B seçeneği).
2. oturum: 24 Ekim, gece yarısından sonra
Çalışma düzeni değişikliği: Üç seçenek konuşuldu, 1 seçildi (Claude Code yazar). ADR-002 yazıldı, proje talimatları güncellendi.
CLAUDE.md: Claude Code'a projenin kurallarını öğreten dosya oluşturuldu.
Terminal düzeni: İkinci terminal açıldı (biri Claude Code, biri git için). Satır sonu (CRLF) uyarısı görüldü. "auto mode" fark edilip manual moda dönüldü.
Docs commit'leri: README ve brif .NET 10 oldu, çalışma sözleşmesi ADR-002'ye göre güncellendi, CLAUDE.md'nin durum notu güncellendi.
Uç nokta: Program.cs yazıldı, test edildi, 200 ve 404 görüldü.
Geri bildirim: Claude Code ile bu sohbet arasındaki kopukluk ve karışıklık konuşuldu (bölüm 9).
3. Commit'ler ne anlama geliyor?
Mesaj biçimi Conventional Commits: tür: kısa açıklama.

Tür	Anlamı
feat	Yeni özellik ya da yeni kod
fix	Hata düzeltme
docs	Sadece belge değişikliği
chore	Bakım ve iskele işi, davranışı değiştirmeyen
Commit mesajı	Ne yaptı, neden
docs: add project docs, readme and gitignore	İlk kayıt noktası: belgeler, README, .gitignore. Kodu karıştırmamak için ayrı commit.
chore: initialize solution skeleton	Çözüm dosyası ve iki proje (Api, Shared).
docs: close phase 0 and record dotnet 10 decision	Faz 0 kapanışı, ADR-003 (önerilen mesaj).
feat: add product model	Product record'u, Shared projesinde.
chore: reference shared project from api	Api, Shared projesindeki Product'ı görebilsin diye proje referansı.
feat: add product source interface	IProductSource sözleşmesi.
feat: add fake product source with json data	FakeProductSource ve products.json.
docs: add claude code rules and adr-002 (1b14c0f)	CLAUDE.md ve ADR-002 (Claude Code'un raporu).
docs: update CLAUDE.md with adr-002 workflow and current state (c684af8)	CLAUDE.md'ye ADR'ler, durum ve çalışma biçimi eklendi (Claude Code'un raporu).
docs: update target framework to .NET 10 in readme and brief	README ve brifte ".NET 8+" yerine ".NET 10" (Claude Code'un önerisi).
docs: align working agreement with adr-002	Çalışma sözleşmesindeki Roller ve ritüel yeni düzene uydu (Claude Code'un önerisi).
feat: add get product by barcode endpoint	GET /products/{barcode} ucu.
docs: update current state in CLAUDE.md	CLAUDE.md'deki durum notu güncellendi.
chore: point http sample request to products endpoint	.http örnek isteği yeni uca yönlendirildi.
Neden küçük ve ayrı commit'ler? Bir şey bozulursa tek commit'i geri almak kolay olur. Her commit tek bir iş anlatır.

4. Yazılan kodlar ve ne işe yaradıkları
4.1 src\FiyatGor.Shared\Product.cs
namespace FiyatGor.Shared;

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
namespace: Tipin adresi. Başka projeler FiyatGor.Shared içindeki Product'a bu adresle ulaşır.
public: Her proje görebilir.
record: Veri taşımak için kısa yazım. Alanlar yalnızca oluşturulurken verilir. Aynı değerli iki record eşit sayılır.
decimal: Para için. double ikilik sistemde çalıştığı için 0,1 gibi sayıları tam tutamaz (doğrulanmadı, genel bilgi).
? işareti: "Bu kutu boş (null) olabilir". CampaignPrice ve CampaignText kampanya yoksa boş.
Barkod neden string: Üzerinde hesap yapmıyoruz, başındaki sıfır int'te kaybolur, 13 haneli sayı int sınırını aşar.
Neden Shared'da: API ve ileride mobil uygulama aynı tarifi görsün.
4.2 src\FiyatGor.Api\IProductSource.cs
using FiyatGor.Shared;

namespace FiyatGor.Api;

public interface IProductSource
{
    Task<Product?> GetByBarcodeAsync(string barcode);
}
Arayüz (interface): Bir sözleşme. "Bir ürün kaynağı barkodla ürün getirebilmeli" der, nasıl yapacağını söylemez. Metodun gövdesi yok.
Task<Product?>: "Bu işin sonunda bir Product olabilir, bulunamazsa null". Task bekleme gerektiren işleri anlatır. Bugün veri dosyadan geliyor, ileride veritabanı ya da Mikro'dan gelecek.
Async eki: Metodun beklemeli çalıştığını gösteren bir gelenek.
I öneki: Arayüz adlarının başına konan gelenek.
Neden Api projesinde: Veri kaynağını sadece API kullanıyor, Shared küçük kalıyor.
Neden arayüz: ADR-001. API, verinin nereden geldiğini bilmesin. Mikro adaptörü gelince yeni bir sınıf eklenir.
4.3 src\FiyatGor.Api\FakeProductSource.cs
using System.Text.Json;
using FiyatGor.Shared;

namespace FiyatGor.Api;

public class FakeProductSource : IProductSource
{
    private readonly List<Product> _products;

    public FakeProductSource(IWebHostEnvironment env)
    {
        var path = Path.Combine(env.ContentRootPath, "Data", "products.json");
        var json = File.ReadAllText(path);
        _products = JsonSerializer.Deserialize<List<Product>>(json, JsonSerializerOptions.Web) ?? [];
    }

    public Task<Product?> GetByBarcodeAsync(string barcode)
    {
        var product = _products.FirstOrDefault(p => p.Barcode == barcode);
        return Task.FromResult(product);
    }
}
: IProductSource: "Bu arayüzün sözünü tutuyorum". Metodu yazmasam derleyici hata verir.
private readonly List<Product> _products: Ürün listesi. readonly yalnızca bir kez atanır. _ öneki iç alan geleneği.
Yapıcı (constructor): Nesne oluşturulurken bir kez çalışır. Dosya her istekte değil burada okunur, çünkü dosya okumak bellekteki listeye bakmaktan yavaş. Bedeli: products.json değişirse API yeniden başlatılana kadar eski liste geçerli.
IWebHostEnvironment env: Uygulamanın ortam bilgisi. ContentRootPath geliştirme sırasında projenin klasörünü verir. Yayınlanmış uygulamadaki davranışı doğrulanmadı, canlıya alırken kontrol edilecek.
Path.Combine: Yol parçalarını doğru ayraçla birleştirir.
File.ReadAllText: Dosyayı metin olarak okur.
JsonSerializer.Deserialize<List<Product>>(json, JsonSerializerOptions.Web): JSON metnini Product listesine çevirir. Web ayarı camelCase ve harf duyarsızlığı açar, yani JSON'daki barcode alanı Barcode'a bağlanır. Resmi dokümanda doğrulandı.
?? []: Sonuç null ise boş liste kullan.
FirstOrDefault(p => p.Barcode == barcode): Listede ilk eşleşeni bulur, yoksa null. p => ... "her ürün p için şunu sor" demek (lambda).
Task.FromResult(product): Hazır bir sonucu Task içine koyar. Burada bekleyecek bir şey yok ama imza Task istiyor.
4.4 src\FiyatGor.Api\Data\products.json (biçim)
[
  {
    "barcode": "0000000000000",
    "name": "Örnek ürün",
    "brand": "Örnek marka",
    "size": "500 g",
    "price": 0.00,
    "unitPrice": 0.00,
    "unitPriceUnit": "kg",
    "campaignPrice": null,
    "campaignText": null,
    "vatRate": 0,
    "sku": "ORNEK-001",
    "stockQuantity": 0
  }
]
Köşeli parantez bir liste, her süslü parantez bir ürün.
Alan adları camelCase. 12 alanın hepsi bulunur.
Kampanyası olmayan üründe campaignPrice ve campaignText için null.
Bu dosya örnek biçimdir, gerçek ürünler senin dosyanda.
Kural: Product değişirse products.json da aynı adımda güncellenir.
4.5 src\FiyatGor.Api\Program.cs
using FiyatGor.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddSingleton<IProductSource, FakeProductSource>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/products/{barcode}", async (string barcode, IProductSource productSource) =>
{
    var product = await productSource.GetByBarcodeAsync(barcode);
    return product is null ? Results.NotFound() : Results.Ok(product);
})
.WithName("GetProductByBarcode");

app.Run();
WebApplication.CreateBuilder: Uygulamayı kurmak için bir yapılandırıcı açar.
AddOpenApi(): API'nin tarifini (uç noktalar, yanıtlar) üreten belgeyi etkinleştirir. Adres: /openapi/v1.json. Belge uygulama çalışırken kodundan üretilir, diskte duran bir dosya değildir.
AddSingleton<IProductSource, FakeProductSource>(): "Biri IProductSource isterse ona FakeProductSource ver, ve uygulama boyunca tek bir tane oluştur." Soldaki istenen sözleşme, sağdaki gerçekte verilen sınıf.
builder.Build(): Kayıtları kapatıp uygulamayı oluşturur.
IsDevelopment() ve MapOpenApi(): OpenAPI belgesi yalnızca geliştirme sırasında yayınlanır.
UseHttpsRedirection(): http isteklerini https'e yönlendirir. Tarayıcıda http adresi seni https'e atabilir (genel bilgi, doğrulanmadı).
MapGet("/products/{barcode}", ...): "Bu adrese GET isteği gelince şu kodu çalıştır". {barcode} adresin değişen kısmı.
Parametre bağlama: string barcode adresten, IProductSource productSource DI'dan (servis kaydından) dolar. Resmi dokümanda doğrulandı.
await: Task'ın bitmesini bekleyip sonucu alır. async bu yüzden gerekir.
product is null ? Results.NotFound() : Results.Ok(product): null ise 404, değilse 200 ve ürün. 404 kararı burada verilir.
WithName: Uca bir ad verir, OpenAPI belgesinde görünür.
app.Run(): Uygulamayı başlatır ve istek dinler.
5. Kavramlar
5.1 record ve class farkı
Ortak yön: İkisi de bir tip tanımlar.
record: Veri taşımak için. Alanlar varsayılan olarak oluşturulurken verilir, sonra değişmez. Aynı değerlere sahip iki record eşit sayılır.
class: İki nesne aynı değerlere sahip olsa bile farklı nesne sayılır.
Kullanım: API'den gelen JSON, ayarlar, veri taşıma (DTO) için record ideal.
5.2 Arayüz uygulama ve "kalıtım" farkı
class FakeProductSource : IProductSource yazımı arayüzü uygulamaktır. Arayüzde kod yok, sadece söz var. Sınıf o sözü yerine getirir.
Kalıtım (class Çocuk : Ebeveyn) ise ebeveyn sınıfın kodunu miras almaktır. Yazım aynı (:) olduğu için karıştırılır.
Bizdeki yapı haritası:
Product (Shared, record) veri tarifi.
IProductSource (Api) sözleşme.
FakeProductSource (Api) sözleşmeyi uygulayan sınıf.
Program.cs hepsini bağlar (DI).
Gelecek: MikroProductSource da aynı arayüzü uygulayacak, uç nokta değişmeyecek.
5.3 DI (bağımlılık enjeksiyonu), AddSingleton
Fikir: Bir sınıf ihtiyaç duyduğu şeyi kendisi oluşturmaz, dışarıdan ister. Uygulama bunu kayıt defterinden bulup verir.
Bizde: Uç nokta IProductSource ister. Program.cs "ona FakeProductSource ver" diye kayıt tutar. FakeProductSource'un yapıcısı IWebHostEnvironment ister, onu da çerçeve kendisi verir.
Singleton: Uygulama boyunca tek örnek. Dosya bir kez okunur.
Fayda: Uç nokta verinin nereden geldiğini bilmez. Sahte kaynağı gerçek kaynakla değiştirmek tek satırlık iş.
5.4 ? ve null
Product? = "boş dönebilir". string? = "metin ya da boş".
null değeri FakeProductSource içindeki FirstOrDefault üretir (barkod listede yoksa).
null kendi başına 404 yapmaz. Uç noktadaki product is null kontrolü bunu 404'e çevirir.
5.5 Task, async, await
Task "bu iş sonra bitecek" demek. await o işin bitmesini bekler. async bir metotta await kullanılabilmesi içindir.
Beklerken API başka istekleri karşılayabilir (genel bilgi, doğrulanmadı).
Task.FromResult hazır bir sonucu Task içine sarar.
5.6 decimal ve double
Para için decimal: 12,90 gibi fiyatları tam tutar. double ikilik sistemde çalışır, 0.1 + 0.2 == 0.3 ifadesi double ile false verir (genel bilgi).
Bellek farkı ürün başına birkaç bayttır, hissedilmez.
5.7 Proje referansı
dotnet add <Api.csproj> reference <Shared.csproj> Api'nin .csproj dosyasına <ProjectReference Include="..\FiyatGor.Shared\FiyatGor.Shared.csproj" /> satırı ekler.
..\ "bir klasör yukarı çık" demek. Yol, .csproj'un bulunduğu klasöre göredir.
Bu satır olmadan Api, Product'ı göremez.
5.8 HTTP durum kodları
200 OK: İstek başarılı, ürün bulundu, cevap gövdesinde JSON var.
404 Not Found: İstek anlaşıldı ama böyle bir ürün yok. Bu bir sunucu hatası değil.
500: Sunucuda beklenmeyen hata. Bizde ürünün olmaması hata sayılmıyor.
Neden boş cevap ya da hata mesajı değil: mobil uygulama ve terminal sadece durum koduna bakıp "ürün bulunamadı" ekranını gösterebilir.
5.9 200 ve 404 zinciri (adım adım)
Tarayıcı GET /products/<barkod> gönderir.
MapGet ucu barkodu adresten, productSource servisini DI'dan alır.
GetByBarcodeAsync(barkod) çağrılır, FakeProductSource karşılar.
Listede arar. Bulursa ürünü, bulamazsa null döndürür.
Uç nokta null kontrolü yapar: null ise 404, değilse 200 ve ürün JSON'u.
Sorumluluklar ayrı: veri kaynağı HTTP bilmez, uç nokta verinin nereden geldiğini bilmez.
5.10 Şablondaki weatherforecast kodu (artık silindi)
summaries dizisi sıcaklık açıklamalarını tutardı.
Enumerable.Range(1, 5) 1'den 5'e kadar 5 kayıt üretirdi.
Random.Shared.Next(-20, 55) -20 ile 54 arası rastgele sayı verir, üst sınır dahil değildir.
TemperatureF saklanan bir değer değil, TemperatureC'den hesaplanan bir özellikti.
Uç nokta kodu her GET isteğinde çalışır, açılışta değil. Sayfayı yenileyince değerler değişirdi.
5.11 JsonSerializerOptions.Web
Camel case (barcode) ve harf duyarsız eşleşme. Resmi dokümanda doğrulandı.
Konumsal (positional) bir record ek bir ayar olmadan JSON'dan okunabilir. Doğrulandı.
5.12 OpenAPI
OpenAPI belgesi API'nin makine tarafından okunan tarifi: hangi uçlar, hangi yanıtlar var.
ASP.NET Core yalnızca belgeyi üretir. Tıklanabilir arayüz (Swagger UI, Scalar gibi) ayrıca eklenir. Hangisini ekleyeceğimiz açık karar.
TypedResults kullanılırsa yanıt tipleri (200, 404) belgeye daha zengin yazılır (Claude Code'un iddiası, denemedik). Dokümanda TypedResults önerilir.
6. Terminal, Git ve araçlar
6.1 Terminal düzeni
İki terminal: biri Claude Code için, biri senin komutların (git, dotnet) için. VS Code'da terminal panelindeki + ya da bölme simgesi.
Claude Code'un açık olduğu terminale git status yazma, o terminal Claude'un girişini bekler.
Gerçek terminal ile sohbet panelleri farklı şeyler. Copilot Chat sohbet panelidir ve Agent modunda kendi komut çalıştırabilir. Terminal alt panelde açılır (Ctrl+J).
6.2 Git komutları
Komut	Anlamı
git status	Hangi dosya değişmiş, hangisi commit'e hazır
git diff	Değişikliklerin satır satır farkı
git add <dosya>	Dosyayı commit'e hazırlar
git add .	Bulunduğun klasördeki her değişikliği hazırlar
git commit -m "mesaj"	Hazırlananları kalıcı kayıt yapar
git log --oneline	Commit geçmişini tek satırda listeler
git push	Commit'leri GitHub'a gönderir
U harfi (untracked): Git'in henüz görmediği dosya. Hata değil.
Satır sonu uyarısı: "LF will be replaced by CRLF". Windows satır sonu için CRLF, Linux ve Mac LF kullanır. Git bunu çevirir. İçerik değişmez, bir şey yapman gerekmez. Kalıcı çözüm için dotnet new gitattributes şablonu var. Bu açıklama genel bilgiye dayanır (doğrulanmadı).
Önerilen sıra: Önce git diff, ne değiştiğini gör, sonra git add, sonra git commit.
6.3 .NET komutları
Komut	Anlamı
dotnet new list	Kurulu şablonları listeler
dotnet new <şablon> -n <ad> -o <klasör>	Şablondan proje üretir
dotnet sln <çözüm> add <proje.csproj>	Projeyi çözüme ekler
dotnet sln <çözüm> list	Çözümdeki projeleri listeler
dotnet add <proje> reference <proje>	Proje referansı ekler
dotnet build	Derler
dotnet run	Çalıştırır
Ctrl+C	Çalışan uygulamayı durdurur
--help	Bir komutun yardım metni
dotnet run --project <yol> yazımı dokümandan doğrulanmadı.
-n ad, -o çıktı klasörü. -o yalnızca dotnet new içindir, dotnet sln add içinde yoktur.
Yol .csproj dosyasına gitmeli, klasöre değil.
6.4 Claude Code notları
Kurulum: irm https://claude.ai/install.ps1 | iex, sonra claude --version. Kurucu PATH'i kendisi değiştirmez. "Komut tanınmıyor" hatasında dosya %USERPROFILE%\.local\bin\claude.exe konumundadır. Kontrol: Test-Path "$env:USERPROFILE\.local\bin\claude.exe". Gerekirse o klasör kullanıcı PATH'ine eklenir, editör kapatılıp açılır. Tanı için claude doctor. (Resmi dokümandan doğrulandı.)
İzin modları (resmi doküman): default (komut satırında "Manual"), acceptEdits, plan, auto, dontAsk, bypassPermissions. Manual modda dosya yazmadan önce sorar. Shift+Tab modlar arasında gezinir.
"auto mode": Ekranda "auto mode on" görmüştün. auto modunu ayrıntılı okumadım, tam neye izin verdiğini bilmiyorum. Bizim anlaşmamız manual mod (her yazmayı sen onaylarsın).
"Yes, and don't ask again": Oturum bitene kadar bir daha sormaz. Şimdilik seçilmesin.
/permissions: Verilen izinleri listeler (doğrulanmadı).
CLAUDE.md: Proje kökündeki dosya, her oturumda otomatik okunur. Talimat olarak okunur, zorlayıcı değildir. /init mevcut dosyayı iyileştirmeyi önerir. Asıl güvence izin sorularıdır.
VS Code eklentisi ve terminal: İkisi de aynı Claude Code ve aynı hesap. Biz terminali seçtik (ADR-002).
Claude Code'un doğru davranışları (terminal kaydından):
ADR-002 zaten karar defterinde olduğu için ikinci kez yazmadı.
git commit çalıştırmadı, CLAUDE.md'deki kural nedeniyle komutu önerdi.
Dosyaları bulup önce listeledi, sonra sadece ilgili satırları değiştirdi.
Dikkat edilecek davranış: Kendi başına fazladan öneriler (TypedResults, .http dosyası, CLAUDE.md'yi genişletme) ve her adımda commit mesajı önerdi. Bu, ikinizin çıktılarının üst üste binmesine yol açtı (bölüm 9).
7. Faz 1'de verilen kararlar (özet)
Karar	Seçilen	Gerekçe
Hedef framework	.NET 10 (ADR-003)	LTS, SDK kurulu, .NET 8 desteği bitiyor (doğrulanmadı)
Fiyat türü	decimal	Para için doğru, double hata biriktirebilir
Kapsam	B (12 alanın hepsi)	Senin tercihin
IProductSource nerede	Api projesinde (A)	Sadece API kullanıyor
Bulunamazsa	null (uçta 404)	Basit, HTTP'ye net çevrilir
Veri kaynağı	JSON dosyası (B)	ADR-001'e birebir uyar
Kod yazan taraf	Claude Code (ADR-002)	Hız ve araç pratiği
İzin modu	Manual	Her yazma senin onayından geçer
8. Yararlı bulduklarım, gereksiz ya da riskli bulduklarım
Yararlı:

Küçük ve ayrı commit'ler.
Karar defteri (ADR): neden öyle yaptığını aylar sonra hatırlatır.
İkinci terminal: kod yazılırken commit'i kendi gözünle atmak.
git diff ile değişikliği commit'ten önce görmek.
Manual izin modu.
CLAUDE.md: Claude Code'un projeyi her oturumda öğrenmesi.
Önce listele, sonra değiştir (Claude Code'a ".NET 8 geçen yerleri bul" demek).
Gereksiz ya da riskli:

"auto mode" (anlaşmamızı atlıyor).
"Yes, and don't ask again" seçeneği.
Copilot'un Agent modunda komut çalıştırması (ne olduğunu görmeden iş yapıyor).
Aynı konuda iki yerden uzun cevap gelmesi.
Claude Code'un her adımda kendi commit mesajını önermesi (ben de önerdiğim için çift ses).
TypedResults ve .http dosyası gibi erken öneriler: öğrenme sırasını bozar.
CLAUDE.md'ye çok uzun durum notu: çabuk eskir.
9. Çalışma düzenindeki karışıklık ve çözümü
Sorun: Claude Code ve Projects sohbeti birbirinden habersiz. İkisi de commit mesajı, alternatif ve uzun çıktı üretiyor, sen aradaki tek aktarıcısın.

Önerilen düzen:

Roller net ayrılsın. Claude Code: sessiz uygulayıcı, sadece istenen işi yapar, kısa rapor verir. Projects sohbeti: açıklama, karar, commit mesajı ve öğrenme.
Her adım için tek talimat. Projects sohbeti sana kopyalanacak tek bir komut verir. Claude Code'a başka bir şey söylemezsin.
Commit mesajını tek kaynak verir: Projects sohbeti. Claude Code mesaj önermez.
Açıklamalar bu deftere taşınır. Sohbet kısa kalır, ayrıntı defterde durur.
Claude Code çıktısını sadece anlamadığında yapıştır. Her çıktıyı yapıştırman gerekmez.
CLAUDE.md'ye "Çıktı kuralları" bölümü eklenir (aşağıda).
Yedek plan: Karışıklık sürerse 2. seçeneğe (Projects sohbetinde kodu yazmak, sen yapıştırırsın) dönülebilir.
CLAUDE.md'ye eklenecek önerilen bölüm:

## Çıktı kuralları
- Sadece istenen işi yap. Ek dosya, ek öneri, alternatif ya da yan görev ekleme.
- Cevabın en fazla 6 satır olsun: ne yaptığını söyle, değişen dosyaları listele.
- Soru sorma. Yalnızca işi sürdüremeyecek kadar belirsizsen sor.
- Commit mesajı önerme. Bir sonraki adımı önerme. Bunları Esma, Projects sohbetinden alır.
Not: CLAUDE.md'deki "dosyayı yazmadan önce nedenini anlat, yazdıktan sonra satır satır özetle" ve "en az iki seçenek sun" satırlarıyla çelişir. Açıklama işi artık Projects sohbetinde, bu satırlar kısaltılmalıdır.

10. Hatalar ve düzeltmeler (benim hatalarım dahil)
"Üç proje" demiştim, iki proje sıralamıştım. Doğrusu şimdilik iki (Api, Shared). Mobile Faz 3'te.
dotnet sln add içinde -o yoktu. Ayrıca add iki kez yazılmıştı.
Tarih: 19 Ekim'i yazım hatası sanmıştım. Yerel saat UTC+3 olduğu için tarih gerçekten 19'du. Karar tarihleri yerel saate göre yazılır.
".NET 8+" ifadesini README'de değil briftte sanmıştım. İkisinde de varmış (Claude Code buldu).
Copilot Agent'ın komutları: Git'i ve Shared projesini muhtemelen Copilot başlattı. Gerçek terminalle karıştırılmıştı.
"auto mode": Anlaşmaya aykırı olduğu geç fark edildi.
ADR-002 tarihi: "2026-10-23" yazıldı, ama yazım yerel saatle 24 Ekim'e denk geliyor olabilir. Kontrol et.
11. Açık işler
Claude Code'a "Çıktı kuralları" eklemek (bölüm 9) ve ADR-002'ye küçük bir not.
TypedResults geçişi (ayrı küçük adım).
OpenAPI arayüzü kararı (Swagger UI, Scalar gibi), Faz 1 başlığındaki "Swagger" kısmı.
Bu defteri repoya docs\ogrenme-gunlugu.md olarak taşımak.
.http dosyasının VS Code'da çalışması için eklenti gerekip gerekmediğini kontrol etmek (doğrulanmadı).
Faz 1 kapanışı: günlük, brif güncellemesi, yeni araç.
JSON dosyasının yayınlanmış uygulamada nereye kopyalandığı (canlıya alırken).
MAUI projesini Faz 3'e ertelemenin net onayı.
CRLF uyarısı için .gitattributes (isteğe bağlı).
12. Kendine sor: geri anlatma soruları
FakeProductSource : IProductSource yazımı kalıtım mı, arayüz uygulamak mı? Fark nedir?
AddSingleton<IProductSource, FakeProductSource> satırının sol ve sağ tarafı ne anlama geliyor?
Dosyayı neden yapıcıda bir kez okuyoruz, her istekte değil?
null'ı kim üretiyor, 404'ü kim üretiyor?
Neden 404, neden boş cevap ya da 500 değil?
Product? ve Task<Product?> ikisi birlikte ne anlatıyor?
Barkod neden string, fiyat neden decimal?
record ile class arasındaki fark nedir?
Proje referansı olmasaydı ne olurdu?
git diff ile git status arasındaki fark nedir?
Manual izin modu neden önemli? "Yes, and don't ask again" neden şimdilik seçilmiyor?
CLAUDE.md zorlayıcı mı? Asıl güvence ne?
Neden iki terminal kullanıyoruz?
ADR neden yazıyoruz, ADR-002 neydi?
13. Kısa sözlük
API: Programların birbirinden veri istediği arayüz.
Uç nokta (endpoint): API'de bir adres ve onun karşılığı kod.
Minimal API: Controller sınıfı olmadan, doğrudan adres ve kodla yazılan API biçimi.
JSON: Veriyi metin olarak taşıyan biçim.
DI (bağımlılık enjeksiyonu): İhtiyaç duyulan nesnenin dışarıdan verilmesi.
Singleton: Uygulama boyunca tek örnek.
Arayüz (interface): Sözleşme, gövdesiz metot imzaları.
Record: Veri taşıma tipi, alanlar sonradan değişmez, eşitlik değere göre.
null: "Değer yok".
Task / async / await: Bekleme gerektiren işlerin yazımı.
ADR: Mimari karar kaydı.
Conventional Commits: tür: açıklama biçimli commit mesajları.
PATH: Terminalin komutları aradığı klasörler listesi.
CRLF / LF: Satır sonu işaretleri (Windows / Linux ve Mac).
Untracked: Git'in henüz görmediği dosya.
CLAUDE.md: Claude Code'un her oturumda okuduğu proje talimat dosyası.
LTS: Uzun destekli sürüm.
OpenAPI: API'nin makine tarafından okunan tarifi.
Continued from “1. oturum: 22 Ekim akşamı - 23 Ekim sabaha karşı”
Continued from “1. oturum: 22 Ekim akşamı - 23 Ekim sabaha karşı”