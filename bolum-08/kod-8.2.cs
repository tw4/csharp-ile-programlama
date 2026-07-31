// Kod 8.2 — Dikdörtgen ve düzensiz diziler
// Çok Boyutlu ve Düzensiz (Jagged) Diziler

// Dikdörtgen: 3 satır × 4 sütun, tek blok bellek
int[,] tablo = new int[3, 4];
tablo[0, 0] = 1;
Console.WriteLine(tablo.GetLength(0));   // 3 (satır)
Console.WriteLine(tablo.GetLength(1));   // 4 (sütun)

// Düzensiz: dizilerden oluşan dizi, satırlar farklı uzunlukta olabilir
int[][] duzensiz =
[
    [1, 2],
    [3, 4, 5, 6],
    [7]
];
Console.WriteLine(duzensiz[1][2]);       // 5
Console.WriteLine(duzensiz.Length);      // 3 (satır sayısı)
