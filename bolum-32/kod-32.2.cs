// Kod 32.2 — Bir API uygulamasının iskeleti
// Program.cs Anatomisi ve Uygulama Hattı

var builder = WebApplication.CreateBuilder(args);

// 1) Servis kaydı (DI konteyneri)
builder.Services.AddOpenApi();
builder.Services.AddDbContext<GorevContext>(o =>
    o.UseSqlite(builder.Configuration.GetConnectionString("Gorev")));

var app = builder.Build();

// 2) Ara yazılım hattı — SIRA ÖNEMLİDİR
if (app.Environment.IsDevelopment()) app.MapOpenApi();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

// 3) Uç noktalar
app.MapGet("/", () => "Görev API çalışıyor");

app.Run();
