// Kod 16.4 — with ile kopyala-değiştir yaklaşımı
// Değer Eşitliği ve with İfadesi

public record SiparisSatiri(string UrunKodu, int Adet, decimal BirimFiyat)
{
    public decimal Tutar => Adet * BirimFiyat;
}

var ilk = new SiparisSatiri("KLV-01", 2, 750m);
var guncel = ilk with { Adet = 3 };   // yeni nesne

Console.WriteLine(ilk.Tutar);    // 1500
Console.WriteLine(guncel.Tutar); // 2250
Console.WriteLine(ilk == guncel); // False
