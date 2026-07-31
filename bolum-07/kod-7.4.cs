// Kod 7.4 — foreach ile koleksiyon gezmek
// foreach ve IEnumerable İlişkisi

string[] sehirler = ["Ankara", "İzmir", "Bursa"];

foreach (string sehir in sehirler)
    Console.WriteLine(sehir);

// Sözlükte anahtar ve değer birlikte
var stok = new Dictionary<string, int> { ["klavye"] = 12, ["fare"] = 30 };

foreach (var (urun, adet) in stok)
    Console.WriteLine($"{urun}: {adet}");
