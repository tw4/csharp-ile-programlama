// Kod 28.1 — Kendi özniteliğinizi tanımlamak
// Öznitelik (Attribute) Yazmak ve Okumak

[AttributeUsage(AttributeTargets.Property)]
public sealed class BasligiAttribute(string baslik) : Attribute
{
    public string Baslik { get; } = baslik;
}

public class Rapor
{
    [Basligi("Müşteri Adı")] public string Ad { get; set; } = "";
    [Basligi("Toplam Tutar")] public decimal Tutar { get; set; }
}

foreach (var p in typeof(Rapor).GetProperties())
    Console.WriteLine(p.GetCustomAttribute<BasligiAttribute>()?.Baslik ?? p.Name);
