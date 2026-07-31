// Kod 32.8 — Ortak önek, filtre ve yetkilendirmeyi tek yerde toplamak
// Uç Noktaları Gruplamak: MapGroup

var grup = app.MapGroup("/api/v1/gorevler")
               .WithTags("Görevler")
               .RequireAuthorization();

grup.MapGet("/",          ListeleAsync);
grup.MapGet("/{id:int}",  GetirAsync).WithName("GorevGetir");
grup.MapPost("/",         OlusturAsync).AllowAnonymous();
grup.MapDelete("/{id:int}", SilAsync);

// Uç nokta gövdelerini ayrı static metotlara taşımak Program.cs'i temiz tutar.
