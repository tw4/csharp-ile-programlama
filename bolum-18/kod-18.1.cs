// Kod 18.1 — SRP ihlalini parçalama örneği
// Tek Sorumluluk ve Açık/Kapalı İlkeleri

public sealed class FaturaServisi
{
    private readonly IFiyatHesaplayici _hesaplayici;
    private readonly IFaturaDeposu _depo;
    private readonly IBildirimGonderici _bildirim;

    public FaturaServisi(
        IFiyatHesaplayici hesaplayici,
        IFaturaDeposu depo,
        IBildirimGonderici bildirim)
    {
        _hesaplayici = hesaplayici;
        _depo = depo;
        _bildirim = bildirim;
    }

    public async Task OlusturAsync(Fatura f, CancellationToken ct = default)
    {
        f.Toplam = _hesaplayici.Hesapla(f);
        await _depo.KaydetAsync(f, ct);
        await _bildirim.GonderAsync(f.MusteriEposta, "Fatura hazır", ct);
    }
}
