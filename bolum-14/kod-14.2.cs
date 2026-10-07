// Kod 14.2 — Sanal metodu geçersiz kılmak
// virtual, override ve new

public class Calisan
{
    public virtual decimal MaasHesapla() => 30_000m;
}

public class Yonetici : Calisan
{
    public override decimal MaasHesapla() => base.MaasHesapla() * 1.5m;
}

Calisan c = new Yonetici();
Console.WriteLine(c.MaasHesapla());  // 45000,0 -> çalışma zamanı tipi belirler
