// Kod 12.8 — Statik üyeler ve statik sınıf
// static Üyeler ve static Sınıflar

public class Musteri
{
    private static int _sayac;                    // tüm nesneler paylaşır
    public static int ToplamMusteri => _sayac;

    public Musteri() => _sayac++;
}

new Musteri(); new Musteri();
Console.WriteLine(Musteri.ToplamMusteri);         // 2

// Statik sınıf: nesnesi oluşturulamaz, yalnızca yardımcı metotlar içerir
public static class Donusturucu
{
    public static decimal LiradanDolara(decimal tl, decimal kur) => tl / kur;
}
