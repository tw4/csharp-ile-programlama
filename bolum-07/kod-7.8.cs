// Kod 7.8 — İç içe döngü yerine sözlük
// İç İçe Döngüler ve Performans Notları

// YAVAŞ — her müşteri için tüm siparişler taranıyor
foreach (var m in musteriler)
    foreach (var s in siparisler)
        if (s.MusteriId == m.Id) Isle(m, s);

// HIZLI — siparişler bir kez gruplanıyor
var grupli = siparisler.ToLookup(s => s.MusteriId);

foreach (var m in musteriler)
    foreach (var s in grupli[m.Id]) Isle(m, s);
