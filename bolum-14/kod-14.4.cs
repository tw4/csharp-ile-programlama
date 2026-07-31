// Kod 14.4 — Ortak davranış + zorunlu uygulama
// abstract Sınıflar ve Soyut Üyeler

public abstract class Sekil
{
    public abstract double AlanHesapla();               // uygulanması zorunlu
    public void Yazdir() => Console.WriteLine($"{GetType().Name}: {AlanHesapla():F2}");
}

public sealed class Daire(double r) : Sekil
{
    public override double AlanHesapla() => Math.PI * r * r;
}

public sealed class Kare(double kenar) : Sekil
{
    public override double AlanHesapla() => kenar * kenar;
}

Sekil[] sekiller = [new Daire(2), new Kare(3)];
foreach (var s in sekiller) s.Yazdir();
