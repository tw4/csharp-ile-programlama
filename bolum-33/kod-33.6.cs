// Kod 33.6 — Listeleme uç noktasının olması gereken hâli
// Sayfalama, Filtreleme ve Sıralama

public record SayfaliSonuc<T>(IReadOnlyList<T> Ogeler, int Toplam, int Sayfa, int Boyut);

app.MapGet("/gorevler", async (
    GorevContext db,
    string? ara,
    bool? tamamlandi,
    string sirala = "tarih",
    int sayfa = 1,
    int boyut = 20,
    CancellationToken ct = default) =>
{
    boyut = Math.Clamp(boyut, 1, 100);

    IQueryable<Gorev> sorgu = db.Gorevler.AsNoTracking();

    if (!string.IsNullOrWhiteSpace(ara))
        sorgu = sorgu.Where(g => g.Baslik.Contains(ara));

    if (tamamlandi is not null)
        sorgu = sorgu.Where(g => g.Tamamlandi == tamamlandi);

    sorgu = sirala switch
    {
        "baslik" => sorgu.OrderBy(g => g.Baslik),
        _        => sorgu.OrderByDescending(g => g.OlusturmaTarihi)
    };

    int toplam = await sorgu.CountAsync(ct);
    var ogeler = await sorgu.Skip((sayfa - 1) * boyut).Take(boyut)
                            .Select(g => new GorevDto(g.Id, g.Baslik, g.Tamamlandi))
                            .ToListAsync(ct);

    return TypedResults.Ok(new SayfaliSonuc<GorevDto>(ogeler, toplam, sayfa, boyut));
});
