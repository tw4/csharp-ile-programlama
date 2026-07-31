// Kod 14.1 — base ile taban sınıf kurucusunu ve üyelerini kullanmak
// Kalıtımın Temelleri ve base Anahtar Sözcüğü

public class Calisan
{
    public string Ad { get; }
    public decimal TabanMaas { get; }

    public Calisan(string ad, decimal tabanMaas)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ad);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(tabanMaas);
        Ad = ad;
        TabanMaas = tabanMaas;
    }

    public virtual decimal MaasHesapla() => TabanMaas;
}

public class SatisTemsilcisi : Calisan
{
    public decimal Prim { get; }

    public SatisTemsilcisi(string ad, decimal maas, decimal prim)
        : base(ad, maas)                 // taban kurucu çağrısı
    {
        ArgumentOutOfRangeException.ThrowIfNegative(prim);
        Prim = prim;
    }

    public override decimal MaasHesapla() => base.MaasHesapla() + Prim;
}
