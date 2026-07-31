// Kod 20.2 — Filtreleme ve projeksiyon zinciri
// Filtreleme, Projeksiyon ve Sıralama

var sonuc = urunler
    .Where(u => u.Stok > 0 && u.Fiyat >= 500m)
    .OrderByDescending(u => u.Fiyat)
    .Select(u => new { u.Kod, u.Ad, u.Fiyat });

foreach (var s in sonuc)
    Console.WriteLine($"{s.Kod} - {s.Ad} - {s.Fiyat:C}");
