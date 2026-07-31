// Kod 11.7 — Sık yapılan hata: tam sayı bölmesi
// Sayısal İşlemler: Math Sınıfı

int a = 7, b = 2;

Console.WriteLine(a / b);              // 3    <- tam sayı bölmesi
Console.WriteLine((double)a / b);      // 3,5  <- doğru sonuç
Console.WriteLine(a % b);              // 1    kalan
