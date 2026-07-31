// Kod 24.3 — Sıralı ve paralel çalıştırma farkı
// async ve await’in Çalışma Mantığı

// Sıralı: toplam süre = t1 + t2
var a = await IndirAsync(url1);
var b = await IndirAsync(url2);

// Paralel: toplam süre ≈ max(t1, t2)
Task<string> t1 = IndirAsync(url1);
Task<string> t2 = IndirAsync(url2);
string[] sonuclar = await Task.WhenAll(t1, t2);
