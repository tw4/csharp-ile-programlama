// Kod 25.3 — C# 13 ile gelen özel Lock tipi
// SemaphoreSlim ve Lock Nesnesi (System.Threading.Lock)

public sealed class Sayac
{
    private readonly Lock _kilit = new();     // System.Threading.Lock
    private int _deger;

    public void Artir()
    {
        lock (_kilit)      // Lock tipi için özel, hızlı yol kullanılır
        {
            _deger++;
        }
    }

    // Kilitsiz alternatif
    public void HizliArtir() => Interlocked.Increment(ref _deger);
}
