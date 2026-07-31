// Kod 33.4 — Üç koruyucu ara yazılım
// CORS, Hız Sınırlama ve Çıktı Önbelleği

builder.Services.AddCors(o => o.AddPolicy("web", p => p
    .WithOrigins("https://ornek.com")
    .AllowAnyHeader()
    .AllowAnyMethod()));

builder.Services.AddRateLimiter(o => o.AddFixedWindowLimiter("varsayilan", l =>
{
    l.PermitLimit = 100;
    l.Window = TimeSpan.FromMinutes(1);
    l.QueueLimit = 0;
}));

builder.Services.AddOutputCache();

app.UseCors("web");
app.UseRateLimiter();
app.UseOutputCache();

app.MapGet("/gorevler", ListeleAsync)
   .CacheOutput(p => p.Expire(TimeSpan.FromSeconds(30)))
   .RequireRateLimiting("varsayilan");
