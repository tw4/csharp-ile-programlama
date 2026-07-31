# C# ile Programlama — Kod Listeleri

**C# ile Programlama — .NET 10 ve C# 14 ile Temellerden Profesyonel Uygulamaya**
kitabındaki kod listelerinin tamamı.

Kitaptaki her liste burada aynı numarayla bulunur. Örneğin kitapta **Kod 4.2** olarak
geçen liste, bu depoda [`bolum-04/kod-4.2.cs`](bolum-04/kod-4.2.cs) dosyasıdır.

## Yapı

```
bolum-01/          1. Bölüm — C# ve .NET Ekosistemi
  README.md        bölümdeki listelerin dizini
  kod-1.1.cs
  kod-1.2.il
bolum-02/
...
bolum-41/
ek-b/              EK B — dotnet CLI Komut Referansı
on-bolum/          Bu Kitap Nasıl Okunmalı
```

Her bölüm klasöründeki `README.md`, o bölümün listelerini numara ve açıklamalarıyla
birlikte tablo hâlinde verir.

## Listeler nasıl çalıştırılır

Listelerin çoğu, anlatımın odağını kaybetmemek için **kendi başına çalışan bir program
değil, ilgili parçadır**. Bir listeyi denemenin en pratik yolu boş bir konsol projesi
açıp listeyi `Program.cs` içine koymaktır:

```bash
dotnet new console -o deneme
cd deneme
# kod-4.2.cs içeriğini Program.cs'e kopyalayın
dotnet run
```

.NET 10 ile tek dosyalık çalıştırma da mümkündür:

```bash
dotnet run kod-4.2.cs
```

Sınıf veya metot bildirimi içeren listelerde `using` satırlarını ve gerekiyorsa
kapsayıcı sınıfı eklemeniz gerekebilir. Web API, EF Core ve test listeleri ilgili
paketlerin kurulu olduğu bir projede çalışır; hangi paketlerin gerektiği kitabın ilgili
bölümünde yazılıdır.

### Başvuru listeleri

11. bölümdeki bazı listeler bir tipin en sık kullanılan üyelerini yan yana gösteren
**başvuru listeleridir**. Her satır bir çağrıyı ve yorum içinde sonucunu gösterir;
çalıştırılmak için değil, aradığınız üyeyi tek bakışta bulmanız için hazırlanmıştır.
Bunlar olduğu gibi derlenmez.

## Gereksinimler

- .NET 10 SDK (LTS)
- Herhangi bir editör: Visual Studio, VS Code veya Rider

Kurulum adımları kitabın 2. bölümünde ayrıntılı olarak anlatılmıştır.

## Doğrulama

Depodaki C# listeleri, kitabın üretim hattında Roslyn ile söz dizimi denetiminden
geçirilir. Son denetimde 193 C# listesinin tamamı .NET 10 / C# 14 söz dizimiyle
geçerlidir.

## Katkı ve geri bildirim

Bir listede hata bulursanız veya bir açıklama yanlış geldiyse issue açabilirsiniz.
Kitaptaki liste numarasını (`Kod 12.4` gibi) belirtmeniz düzeltmeyi kolaylaştırır.

## Lisans

Kod listeleri MIT Lisansı ile sunulur; ayrıntı için [LICENSE](LICENSE) dosyasına bakın.
Kitabın metni bu lisansın kapsamı dışındadır ve tüm hakları saklıdır.
