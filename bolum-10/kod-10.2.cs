// Kod 10.2 — Aradeğerleme ve biçim belirteçleri
// String Interpolation ve Ham Metin Değişmezleri

string ad = "Mert";
decimal tutar = 1234.5m;
DateTime tarih = new(2026, 7, 26);

Console.WriteLine($"Sayın {ad}, borcunuz {tutar:C}.");
Console.WriteLine($"Tarih: {tarih:dd MMMM yyyy}");
Console.WriteLine($"Toplam: {tutar * 2:N2}");        // ifade yazılabilir
Console.WriteLine($"{ad,10}|");                       // sağa hizala
Console.WriteLine($"{ad,-10}|");                      // sola hizala

// Süslü parantezin kendisini yazmak için ikiye katlanır
Console.WriteLine($"{{süslü}} {ad}");
