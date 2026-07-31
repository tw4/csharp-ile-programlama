// Kod 34.3 — İş mantığını uç noktadan ayırmak
// Servis Katmanı ve İş Kuralları

public sealed class GorevServisi(IGorevDeposu depo, TimeProvider zaman)
{
    public async Task<Sonuc<GorevDto>> OlusturAsync(GorevOlusturDto dto, CancellationToken ct)
    {
        if (dto.Bitis is { } b && b < DateOnly.FromDateTime(zaman.GetUtcNow().Date))
            return Sonuc<GorevDto>.Hata("Bitiş tarihi geçmiş olamaz.");

        var gorev = new Gorev { Baslik = dto.Baslik.Trim(), Bitis = dto.Bitis };
        await depo.EkleAsync(gorev, ct);

        return Sonuc<GorevDto>.Basarili(new GorevDto(gorev.Id, gorev.Baslik, false));
    }
}

// TimeProvider enjekte edildiği için testlerde zaman sabitlenebilir.
