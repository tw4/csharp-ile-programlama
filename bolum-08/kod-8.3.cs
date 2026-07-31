// Kod 8.3 — En çok kullanılan dizi işlemleri
// Dizi Metotları ve System.Array

int[] sayilar = [5, 3, 9, 1, 7];

Array.Sort(sayilar);                      // 1 3 5 7 9  (diziyi değiştirir)
Array.Reverse(sayilar);                   // 9 7 5 3 1
int yer = Array.IndexOf(sayilar, 5);      // 2   (yoksa -1)
Array.Clear(sayilar, 0, 2);               // ilk iki elemanı sıfırla

int[] kopya = new int[5];
Array.Copy(sayilar, kopya, sayilar.Length);

bool varMi = Array.Exists(sayilar, x => x > 8);
int ilk    = Array.Find(sayilar, x => x > 4);

// LINQ ile daha okunaklı alternatifler:
Console.WriteLine(sayilar.Max());
Console.WriteLine(sayilar.Sum());
Console.WriteLine(string.Join(", ", sayilar));
