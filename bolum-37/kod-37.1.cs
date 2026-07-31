// Kod 37.1 — Factory deseni ile nesne üretimini merkezileştirmek
// Yaratımsal Desenler: Factory, Builder, Singleton

public interface IOdeme { Task<bool> TahsilEtAsync(decimal tutar); }

public sealed class OdemeFabrikasi(IServiceProvider sp)
{
    public IOdeme Olustur(string yontem) => yontem switch
    {
        "kart"   => sp.GetRequiredService<KrediKartiOdeme>(),
        "havale" => sp.GetRequiredService<HavaleOdeme>(),
        _        => throw new NotSupportedException($"Bilinmeyen yöntem: {yontem}")
    };
}
