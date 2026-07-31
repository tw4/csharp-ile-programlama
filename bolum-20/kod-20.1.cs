// Kod 20.1 — Aynı sorgunun iki yazımı
// Sorgu Söz Dizimi ve Metot Söz Dizimi

record Calisan(string Ad, string Departman, decimal Maas);

Calisan[] calisanlar =
[
    new("Mert", "Yazılım", 65_000),
    new("Ayşe", "Yazılım", 72_000),
    new("Can",  "Satış",   48_000)
];

// Sorgu söz dizimi
var q1 = from c in calisanlar
         where c.Departman == "Yazılım"
         orderby c.Maas descending
         select c.Ad;

// Metot söz dizimi (aynı sonuç)
var q2 = calisanlar
    .Where(c => c.Departman == "Yazılım")
    .OrderByDescending(c => c.Maas)
    .Select(c => c.Ad);

Console.WriteLine(string.Join(", ", q2));   // Ayşe, Mert
