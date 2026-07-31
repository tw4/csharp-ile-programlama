// Kod 16.3 — Değer eşitliği ve otomatik ToString
// record ve record struct

public record Kisi(string Ad, string Soyad, int Yas);
public readonly record struct Koordinat(double Enlem, double Boylam);

var a = new Kisi("Mert", "Türkoğlu", 30);
var b = new Kisi("Mert", "Türkoğlu", 30);

Console.WriteLine(a == b);        // True  -> içerik eşitliği
Console.WriteLine(a);             // Kisi { Ad = Mert, Soyad = Türkoğlu, Yas = 30 }

var yasliHali = a with { Yas = 31 };   // kopyala-ve-değiştir
