// Kod 27.1 — Kaynakları doğru serbest bırakmak
// IDisposable, using ve IAsyncDisposable

await using var havuz = new BaglantiHavuzu();   // blok sonunda DisposeAsync
// ... havuz burada kullanılır ...

public sealed class BaglantiHavuzu : IAsyncDisposable
{
    private readonly List<DbConnection> _baglantilar = [];

    public async ValueTask DisposeAsync()
    {
        foreach (var b in _baglantilar)
            await b.DisposeAsync();

        _baglantilar.Clear();
    }
}
