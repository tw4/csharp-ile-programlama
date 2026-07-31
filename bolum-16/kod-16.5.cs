// Kod 16.5 — Bayrak numaralandırması
// enum Tanımı, Temel Tip ve [Flags]

[Flags]
public enum Izinler : byte
{
    Yok    = 0,
    Okuma  = 1,
    Yazma  = 2,
    Silme  = 4,
    Tumu   = Okuma | Yazma | Silme
}

var izin = Izinler.Okuma | Izinler.Yazma;
Console.WriteLine(izin);                          // Okuma, Yazma
Console.WriteLine(izin.HasFlag(Izinler.Silme));   // False
