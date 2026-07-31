// Kod 12.1 — İlk sınıf ve ondan üretilen nesneler
// Sınıf Tanımı, Alanlar ve Metotlar

public class Musteri
{
    private decimal _bakiye;          // alan — dışarıya kapalı
    public string Ad;                 // alan — doğrudan erişilebilir (önerilmez)

    public void ParaYatir(decimal tutar)
    {
        if (tutar <= 0) return;
        _bakiye += tutar;
    }

    public decimal BakiyeGoster() => _bakiye;
}

var m1 = new Musteri { Ad = "Mert" };
var m2 = new Musteri { Ad = "Ayşe" };

m1.ParaYatir(500);
Console.WriteLine(m1.BakiyeGoster());   // 500
Console.WriteLine(m2.BakiyeGoster());   // 0   -> ayrı nesne, ayrı veri
