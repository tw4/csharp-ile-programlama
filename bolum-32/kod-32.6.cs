// Kod 32.6 — Dört temel işlem uçtan uca
// CRUD Uç Noktalarının Tamamlanması

// LİSTELE
app.MapGet("/gorevler", async (GorevContext db, CancellationToken ct) =>
    await db.Gorevler.AsNoTracking().ToListAsync(ct));

// OLUŞTUR
app.MapPost("/gorevler", async (GorevOlusturDto dto, GorevContext db) =>
{
    var g = new Gorev { Baslik = dto.Baslik, Bitis = dto.Bitis };
    db.Gorevler.Add(g);
    await db.SaveChangesAsync();
    return TypedResults.Created($"/gorevler/{g.Id}", g);       // 201 + Location
});

// GÜNCELLE
app.MapPut("/gorevler/{id:int}", async (int id, GorevGuncelleDto dto, GorevContext db) =>
{
    var g = await db.Gorevler.FindAsync(id);
    if (g is null) return Results.NotFound();

    g.Baslik = dto.Baslik;
    g.Tamamlandi = dto.Tamamlandi;
    await db.SaveChangesAsync();
    return Results.NoContent();                                 // 204
});

// SİL
app.MapDelete("/gorevler/{id:int}", async (int id, GorevContext db) =>
    await db.Gorevler.Where(g => g.Id == id).ExecuteDeleteAsync() > 0
        ? Results.NoContent()
        : Results.NotFound());
