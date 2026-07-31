// Kod 12.2 — Birincil yapıcı (primary constructor) ile kısa sınıf tanımı
// Yapıcı Metotlar (Constructor) ve Birincil Yapıcılar

public class Hesap(string sahibi, decimal baslangic)
{
    private decimal _bakiye = baslangic;

    public string Sahibi { get; } = sahibi;

    public void Yatir(decimal tutar)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(tutar);
        _bakiye += tutar;
    }

    public override string ToString() => $"{Sahibi}: {_bakiye:C}";
}

var h = new Hesap("Mert Türkoğlu", 1000m);
h.Yatir(250m);
Console.WriteLine(h);
