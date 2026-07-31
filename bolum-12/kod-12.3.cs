// Kod 12.3 — Klasik yapıcı, aşırı yükleme ve zincirleme
// Yapıcı Metotlar (Constructor) ve Birincil Yapıcılar

public class Siparis
{
    public string Urun { get; }
    public int Adet { get; }
    public decimal BirimFiyat { get; }

    public Siparis(string urun, int adet, decimal birimFiyat)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(urun);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(adet);

        Urun = urun;
        Adet = adet;
        BirimFiyat = birimFiyat;
    }

    // Zincirleme: bu yapıcı diğerini çağırır
    public Siparis(string urun, decimal birimFiyat)
        : this(urun, 1, birimFiyat) { }
}
