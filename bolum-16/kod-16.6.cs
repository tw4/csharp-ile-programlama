// Kod 16.6 — Birden fazla değer döndürmek
// Demetler (Tuples) ve Yapısal Ayrıştırma (Deconstruction)

(int enKucuk, int enBuyuk, double ortalama) Analiz(int[] sayilar) =>
    (sayilar.Min(), sayilar.Max(), sayilar.Average());

var (min, max, ort) = Analiz([4, 8, 15, 16, 23, 42]);
Console.WriteLine($"min={min}, max={max}, ort={ort:F1}");
