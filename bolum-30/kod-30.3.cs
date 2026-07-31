// Kod 30.3 — appsettings.json'u güçlü tipli sınıfa bağlamak
// Yapılandırma (Configuration) ve Options Deseni

// appsettings.json
// { "Eposta": { "SmtpSunucu": "smtp.ornek.com", "Port": 587 } }

public sealed class EpostaAyarlari
{
    public required string SmtpSunucu { get; init; }
    public int Port { get; init; } = 25;
}

builder.Services.Configure<EpostaAyarlari>(
    builder.Configuration.GetSection("Eposta"));

public sealed class EpostaServisi(IOptions<EpostaAyarlari> ayarlar)
{
    private readonly EpostaAyarlari _ayar = ayarlar.Value;
}
