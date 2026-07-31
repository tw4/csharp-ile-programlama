// Kod 18.3 — DIP ile üst katmanı soyuta bağlamak
// Arayüz Ayrımı ve Bağımlılığın Ters Çevrilmesi

public interface IOdemeAltyapisi
{
    Task<bool> TahsilEtAsync(decimal tutar, CancellationToken ct = default);
}

public sealed class SiparisUygulamasi
{
    private readonly IOdemeAltyapisi _odeme;
    public SiparisUygulamasi(IOdemeAltyapisi odeme) => _odeme = odeme;

    public Task<bool> OdemeAlAsync(decimal tutar, CancellationToken ct = default) =>
        _odeme.TahsilEtAsync(tutar, ct);
}
