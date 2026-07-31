// Kod 12.4 — Özellik türleri bir arada
// Özellikler (Properties), get/set ve init

public class Urun
{
    public required string Ad { get; init; }     // yalnızca oluştururken atanır
    public decimal Fiyat { get; set; }
    public decimal KdvliFiyat => Fiyat * 1.20m;  // hesaplanan, salt okunur
}

var u = new Urun { Ad = "Klavye", Fiyat = 750m };
Console.WriteLine(u.KdvliFiyat);   // 900,00
