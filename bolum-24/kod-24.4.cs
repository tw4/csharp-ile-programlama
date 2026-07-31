// Kod 24.4 — Zaman aşımı ve kullanıcı iptalini birlikte yönetmek
// CancellationToken ile İptal Yönetimi

using var zamanAsimi = new CancellationTokenSource(TimeSpan.FromSeconds(5));

try
{
    await UzunIslemAsync(zamanAsimi.Token);
}
catch (OperationCanceledException)
{
    Console.WriteLine("İşlem iptal edildi veya zaman aşımına uğradı.");
}

async Task UzunIslemAsync(CancellationToken ct)
{
    for (int i = 0; i < 100; i++)
    {
        ct.ThrowIfCancellationRequested();
        await Task.Delay(200, ct);
    }
}
