// Kod 31.3 — Salt okunur sorgularda izlemeyi kapatmak
// Sorgulama, İzleme (Tracking) ve Performans

var yazilar = await db.Yazilar
    .AsNoTracking()                       // değişiklik izleme yükü yok
    .Where(y => y.Blog!.Baslik == "C# Kitabı")
    .OrderByDescending(y => y.Id)
    .Select(y => new { y.Id, y.Icerik })  // yalnızca gereken sütunlar
    .Take(20)
    .ToListAsync(ct);
