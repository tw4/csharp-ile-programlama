// Kod 20.3 — Departman bazında özet çıkarmak
// Gruplama, Birleştirme (Join) ve Kümeleme

var ozet = calisanlar
    .GroupBy(c => c.Departman)
    .Select(g => new
    {
        Departman = g.Key,
        Kisi      = g.Count(),
        Ortalama  = g.Average(c => c.Maas),
        EnYuksek  = g.Max(c => c.Maas)
    })
    .OrderByDescending(x => x.Ortalama);

foreach (var s in ozet)
    Console.WriteLine($"{s.Departman,-10} {s.Kisi} kişi, ort. {s.Ortalama:N0} TL");
