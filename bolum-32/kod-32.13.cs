// Kod 32.13 — Aynı işin Controller ile yazımı
// Controller Tabanlı API’ler

[ApiController]
[Route("api/v1/[controller]")]
public sealed class GorevlerController(GorevContext db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GorevDto>>> Listele(CancellationToken ct)
        => Ok(await db.Gorevler.AsNoTracking()
                               .Select(g => new GorevDto(g.Id, g.Baslik, g.Tamamlandi))
                               .ToListAsync(ct));

    [HttpGet("{id:int}")]
    public async Task<ActionResult<GorevDto>> Getir(int id)
        => await db.Gorevler.FindAsync(id) is { } g
            ? Ok(new GorevDto(g.Id, g.Baslik, g.Tamamlandi))
            : NotFound();
}
