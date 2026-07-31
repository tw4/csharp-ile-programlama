// Kod 21.2 — Metotları parametre olarak geçmek
// Func, Action ve Predicate

Func<int, int, int>  topla  = (a, b) => a + b;
Action<string>       yazdir = m => Console.WriteLine($"[LOG] {m}");
Predicate<int>       ciftMi = n => n % 2 == 0;

yazdir($"Toplam: {topla(3, 4)}");

List<int> sayilar = [1, 2, 3, 4, 5, 6];
Console.WriteLine(string.Join(",", sayilar.FindAll(ciftMi)));   // 2,4,6
