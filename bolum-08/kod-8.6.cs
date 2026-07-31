// Kod 8.6 — Tek söz dizimiyle dizi, liste ve span oluşturma
// Koleksiyon İfadeleri ve Spread Operatörü

int[]       dizi  = [1, 2, 3];
List<int>   liste = [4, 5, 6];
Span<int>   span  = [7, 8, 9];

int[] birlesik = [..dizi, ..liste, 0, ..span];   // spread (..)
Console.WriteLine(string.Join(", ", birlesik));
// 1, 2, 3, 4, 5, 6, 0, 7, 8, 9
