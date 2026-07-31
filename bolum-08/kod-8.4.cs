// Kod 8.4 — Sondan indeksleme ve dilimleme
// Index ve Range Söz Dizimi (^ ve ..)

int[] sayilar = [10, 20, 30, 40, 50];

Console.WriteLine(sayilar[^1]);       // 50  (sondan birinci)
int[] ortadakiler = sayilar[1..4];    // 20, 30, 40
int[] sonIki      = sayilar[^2..];    // 40, 50
int[] kopya       = sayilar[..];      // tamamı
