// Kod 17.4 — Koleksiyon yüzeyini niyete göre daraltmak
// Generic Koleksiyon Tasarımı

public interface IKatalog
{
    IReadOnlyList<Urun> TumunuGetir();
    Urun? KodlaBul(string kod);
}

public sealed class BellekKatalog : IKatalog
{
    private readonly List<Urun> _urunler = [];

    public IReadOnlyList<Urun> TumunuGetir() => _urunler;
    public Urun? KodlaBul(string kod) => _urunler.FirstOrDefault(u => u.Kod == kod);
}
