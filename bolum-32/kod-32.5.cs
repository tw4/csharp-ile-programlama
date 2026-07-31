// Kod 32.5 — Doğru durum kodunu döndürmek
// Sonuç Tipleri: Results, TypedResults ve HTTP Durum Kodları

app.MapGet("/gorevler/{id:int}",
    async Task<Results<Ok<Gorev>, NotFound>> (int id, GorevContext db) =>
{
    Gorev? g = await db.Gorevler.FindAsync(id);
    return g is null
        ? TypedResults.NotFound()          // 404
        : TypedResults.Ok(g);              // 200
});

// TypedResults, OpenAPI belgesine yanıt şemasını da otomatik yazar.
// Results.Created / NoContent / BadRequest / Conflict / Problem ...
