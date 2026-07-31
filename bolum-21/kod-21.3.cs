// Kod 21.3 — Anonim metot ve lambda karşılaştırması
// Anonim Metotlar ve Lambda İfadeleri

Func<int, bool> eskiYazim = delegate (int n) { return n % 2 == 0; };
Func<int, bool> yeniYazim = n => n % 2 == 0;

Console.WriteLine(eskiYazim(4)); // True
Console.WriteLine(yeniYazim(5)); // False
