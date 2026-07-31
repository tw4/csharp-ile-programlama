// Kod 33.8 — Yanıt süresini düşüren pratik ayarlar
// Performans: Projeksiyon, Önbellek ve Sıkıştırma

builder.Services.AddResponseCompression(o => o.EnableForHttps = true);

// Yalnızca gereken sütunlar + izleme kapalı
var liste = await db.Gorevler
    .AsNoTracking()
    .Select(g => new GorevDto(g.Id, g.Baslik, g.Tamamlandi))
    .ToListAsync(ct);

// AOT/hız için kaynak üreteçli JSON
builder.Services.ConfigureHttpJsonOptions(o =>
    o.SerializerOptions.TypeInfoResolverChain.Insert(0, GorevJsonContext.Default));
