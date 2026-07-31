// Kod 18.5 — SONRA — sorumluluklar ayrıştırıldı
// Örnek Vaka: Kötü Tasarımın Yeniden Düzenlenmesi

public sealed class SiparisServisi(
    ISiparisDogrulayici dogrulayici,
    ISiparisDeposu depo,
    IBildirimGonderici bildirim,
    ILogger<SiparisServisi> logger)
{
    public async Task OlusturAsync(Siparis s, CancellationToken ct = default)
    {
        dogrulayici.Dogrula(s);
        await depo.EkleAsync(s, ct);
        await bildirim.GonderAsync(s.Eposta, "Siparişiniz alındı", ct);
        logger.LogInformation("Sipariş {Id} oluşturuldu", s.Id);
    }
}
