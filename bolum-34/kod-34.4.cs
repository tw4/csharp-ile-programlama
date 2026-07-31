// Kod 34.4 — Uç noktaları ayrı bir dosyada toplamak
// Uç Noktaların Yazılması

public static class GorevUcNoktalari
{
    public static RouteGroupBuilder MapGorevler(this IEndpointRouteBuilder app)
    {
        var grup = app.MapGroup("/api/v1/gorevler").WithTags("Görevler");

        grup.MapGet("/",         ListeleAsync);
        grup.MapPost("/",        OlusturAsync);
        grup.MapDelete("/{id:int}", SilAsync);

        return grup;
    }

    private static async Task<IResult> OlusturAsync(
        GorevOlusturDto dto, GorevServisi servis, CancellationToken ct)
    {
        var sonuc = await servis.OlusturAsync(dto, ct);
        return sonuc.BasariliMi
            ? TypedResults.Created($"/api/v1/gorevler/{sonuc.Deger!.Id}", sonuc.Deger)
            : TypedResults.Problem(sonuc.HataMesaji, statusCode: 400);
    }
}

// Program.cs içinde tek satır:  app.MapGorevler();
