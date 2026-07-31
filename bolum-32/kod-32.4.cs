// Kod 32.4 — Verinin isteğin neresinden geldiğini belirlemek
// Rota Parametreleri, Sorgu Dizesi ve Gövde Bağlama

// Rota parametresi: /gorevler/5
app.MapGet("/gorevler/{id:int}", (int id) => $"Görev {id}");

// Sorgu dizesi: /gorevler/ara?metin=rapor&sayfa=2
app.MapGet("/gorevler/ara", (string metin, int sayfa = 1) => $"{metin} - {sayfa}");

// Gövde (JSON) + servis + başlık
app.MapPost("/gorevler", (GorevDto dto,
                          GorevContext db,
                          [FromHeader(Name = "X-Kaynak")] string? kaynak) =>
{
    db.Gorevler.Add(new Gorev { Baslik = dto.Baslik, Kaynak = kaynak });
    return TypedResults.Created($"/gorevler/{dto.Id}");
});

// Açık belirteçler: [FromRoute] [FromQuery] [FromBody] [FromServices] [AsParameters]
