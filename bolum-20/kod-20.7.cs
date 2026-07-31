// Kod 20.7 — Sorgu ne zaman çalışır?
// Ertelenmiş Yürütme (Deferred Execution) Tuzakları

var liste = new List<int> { 1, 2, 3 };
var sorgu = liste.Where(x => x > 1);   // henüz ÇALIŞMADI

liste.Add(4);

Console.WriteLine(string.Join(",", sorgu));   // 2,3,4  -> şimdi çalıştı

// Anlık gerçekleştirme:
var sabit = liste.Where(x => x > 1).ToList(); // sonuç dondurulur
