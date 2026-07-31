// Kod 21.6 — Önerilen olay tetikleme kalıbı
// EventHandler<T> ve Olay Tasarımı Kuralları

public sealed class IslemTamamlandiEventArgs(string islemAdi, TimeSpan sure) : EventArgs
{
    public string IslemAdi { get; } = islemAdi;
    public TimeSpan Sure { get; } = sure;
}

public sealed class IslemYurutucu
{
    public event EventHandler<IslemTamamlandiEventArgs>? Tamamlandi;

    public async Task CalistirAsync(string ad)
    {
        var baslangic = DateTime.UtcNow;
        await Task.Delay(100);
        Tamamlandi?.Invoke(this,
            new IslemTamamlandiEventArgs(ad, DateTime.UtcNow - baslangic));
    }
}
