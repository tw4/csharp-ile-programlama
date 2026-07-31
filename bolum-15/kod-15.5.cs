// Kod 15.5 — IComparable ve IEquatable ile tutarlı sıralama/eşitlik
// Sık Kullanılan BCL Arayüzleri: IComparable, IEquatable, IDisposable

public sealed class Urun : IComparable<Urun>, IEquatable<Urun>
{
    public required string Kod { get; init; }
    public required string Ad { get; init; }
    public decimal Fiyat { get; init; }

    public int CompareTo(Urun? other) =>
        other is null ? 1 : Fiyat.CompareTo(other.Fiyat);

    public bool Equals(Urun? other) =>
        other is not null && Kod == other.Kod;

    public override bool Equals(object? obj) => obj is Urun u && Equals(u);
    public override int GetHashCode() => Kod.GetHashCode();
}

var urunler = new List<Urun>
{
    new() { Kod = "K1", Ad = "Klavye", Fiyat = 750m },
    new() { Kod = "M1", Ad = "Mouse",  Fiyat = 300m }
};
urunler.Sort(); // CompareTo kullanır
