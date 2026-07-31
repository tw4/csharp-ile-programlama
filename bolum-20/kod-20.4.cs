// Kod 20.4 — Join ile iki veri kaynağını birleştirmek
// Gruplama, Birleştirme (Join) ve Kümeleme

var birlesik = siparisler.Join(
    musteriler,
    s => s.MusteriId,
    m => m.Id,
    (s, m) => new { s.Id, Musteri = m.Ad, s.Toplam });

foreach (var x in birlesik)
    Console.WriteLine($"{x.Id} - {x.Musteri} - {x.Toplam:C}");
