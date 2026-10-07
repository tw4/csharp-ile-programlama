// Kod 32.4 — Verinin isteğin neresinden geldiğini belirlemek
// Rota Parametreleri, Sorgu Dizesi ve Gövde Bağlama

// Rota parametresi: /gorevler/5
app.MapGet("/gorevler/{id:int}", (int id) => $"Görev {id}");

// Sorgu dizesi: /gorevler/ara?metin=rapor&sayfa=2
app.MapGet("/gorevler/ara", (string metin, int sayfa = 1) => $"{metin} - {sayfa}");

// Gövde (JSON) + servis + başlık
app.MapPost("/gorevler", async (
    GorevOlusturDto dto,
    GorevContext db,
    [FromHeader(Name = "X-Kaynak")] string? kaynak) =>
{
    var gorev = new Gorev { Baslik = dto.Baslik, Kaynak = kaynak };
    db.Gorevler.Add(gorev);
    await db.SaveChangesAsync();
    return TypedResults.Created($"/gorevler/{gorev.Id}");
});

// Açık belirteçler: [FromRoute] [FromQuery] [FromBody] [FromServices] [AsParameters]
