// Kod 19.2 — Sözlük kullanımının temel kalıpları
// Dictionary<TKey, TValue> ve Hash Tabanlı Arama

var stok = new Dictionary<string, int>
{
    ["klavye"] = 12,
    ["fare"]   = 30
};

if (stok.TryGetValue("fare", out int adet))
    Console.WriteLine($"Fare stoğu: {adet}");

stok["monitör"] = 5;                              // ekle veya güncelle
int mevcut = stok.GetValueOrDefault("kulaklık");  // yoksa 0

foreach (var (urun, sayi) in stok)
    Console.WriteLine($"{urun,-10} {sayi,3}");
