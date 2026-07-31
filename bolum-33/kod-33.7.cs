// Kod 33.7 — Uygulamanın ayakta olduğunu dışarıya bildirmek
// Günlükleme ve Sağlık Denetimleri (Health Checks)

builder.Services.AddHealthChecks()
    .AddDbContextCheck<GorevContext>("veritabani");

app.MapHealthChecks("/saglik");

// Yapılandırılmış günlükleme
app.MapGet("/gorevler/{id:int}", (int id, ILogger<Program> logger) =>
{
    logger.LogInformation("Görev {GorevId} istendi", id);   // şablon parametresi
    // logger.LogInformation($"Görev {id} istendi");        // KULLANMAYIN
});
