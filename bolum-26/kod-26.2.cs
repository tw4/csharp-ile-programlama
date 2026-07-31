// Kod 26.2 — Metin dosyasını satır satır işlemek
// StreamReader ve StreamWriter ile Metin İşlemleri

using var okuyucu = new StreamReader("kayitlar.txt");
using var yazici = new StreamWriter("hatalar.txt", append: true);

string? satir;
while ((satir = okuyucu.ReadLine()) is not null)
{
    if (satir.Contains("ERROR", StringComparison.OrdinalIgnoreCase))
        yazici.WriteLine(satir);
}
