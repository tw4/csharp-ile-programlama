// Kod 19.6 — ConcurrentDictionary ile atomik güncelleme
// Eşzamanlı Koleksiyonlar (Concurrent)

using System.Collections.Concurrent;

var sayac = new ConcurrentDictionary<string, int>();
Parallel.For(0, 1000, _ =>
{
    sayac.AddOrUpdate("islem", 1, (_, mevcut) => mevcut + 1);
});

Console.WriteLine(sayac["islem"]); // 1000
