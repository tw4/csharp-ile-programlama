// Kod 4.7 — Değeri olmayabilen sayılar
// Nullable Değer Tipleri

int? puan = null;

if (puan.HasValue)
    Console.WriteLine(puan.Value);
else
    Console.WriteLine("Puan girilmemiş");

int gosterilecek = puan ?? 0;          // null ise 0
Console.WriteLine(puan.GetValueOrDefault(-1));
