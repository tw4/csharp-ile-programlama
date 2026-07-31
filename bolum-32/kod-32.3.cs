// Kod 32.3 — Birkaç satırda çalışan bir Web API
// Minimal API ile İlk Servis

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddDbContext<BlogContext>(o => o.UseSqlite("Data Source=blog.db"));

var app = builder.Build();
app.MapOpenApi();

app.MapGet("/yazilar", async (BlogContext db, CancellationToken ct) =>
    await db.Yazilar.AsNoTracking().ToListAsync(ct));

app.MapGet("/yazilar/{id:int}", async (int id, BlogContext db) =>
    await db.Yazilar.FindAsync(id) is { } y ? Results.Ok(y) : Results.NotFound());

app.MapPost("/yazilar", async (Yazi yeni, BlogContext db) =>
{
    db.Yazilar.Add(yeni);
    await db.SaveChangesAsync();
    return Results.Created($"/yazilar/{yeni.Id}", yeni);
});

app.Run();
