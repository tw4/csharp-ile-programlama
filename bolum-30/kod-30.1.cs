// Kod 30.1 — Servis kaydı ve yapıcı enjeksiyonu
// Microsoft.Extensions.DependencyInjection

services.AddScoped<ISiparisServisi, SiparisServisi>();
services.AddScoped<ISiparisDeposu, SqlSiparisDeposu>();
services.AddSingleton<ISaat, SistemSaati>();

public sealed class SiparisServisi(ISiparisDeposu depo, ISaat saat)
    : ISiparisServisi
{
    public Task KaydetAsync(Siparis siparis, CancellationToken ct)
    {
        siparis.OlusturmaTarihi = saat.Simdi;
        return depo.EkleAsync(siparis, ct);
    }
}
