// Kod 21.4 — Closure tuzağı ve düzeltmesi
// Kapanışlar (Closures) ve Yakalanan Değişkenler

var islemler = new List<Action>();

for (int i = 0; i < 3; i++)
{
    int kopya = i; // kritik nokta
    islemler.Add(() => Console.WriteLine(kopya));
}

foreach (var islem in islemler) islem(); // 0,1,2
