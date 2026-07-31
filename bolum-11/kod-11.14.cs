// Kod 11.14 — Sayfalama ve zincirleme kullanım
// LINQ’in En Sık Kullanılan Operatörleri

var sayfa = urunler
    .Where(u => u.Aktif)
    .OrderByDescending(u => u.Tarih)
    .Skip((sayfaNo - 1) * sayfaBoyu)
    .Take(sayfaBoyu)
    .Select(u => new { u.Id, u.Ad })
    .ToList();
