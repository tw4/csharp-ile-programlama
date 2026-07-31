// Kod 30.4 — Periyodik çalışan arka plan görevi
// Generic Host ve Arka Plan Servisleri

public sealed class GunlukRaporServisi(ILogger<GunlukRaporServisi> logger)
    : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var zamanlayici = new PeriodicTimer(TimeSpan.FromHours(24));

        while (await zamanlayici.WaitForNextTickAsync(stoppingToken))
        {
            logger.LogInformation("Günlük rapor üretiliyor...");
            // ... rapor üretimi
        }
    }
}
