// Kod 13.2 — Oluşturulduktan sonra değiştirilemeyen tip
// Değişmez (Immutable) Nesne Tasarımı

public sealed record Para(decimal Tutar, string ParaBirimi)
{
    public Para Ekle(Para diger) => ParaBirimi == diger.ParaBirimi
        ? this with { Tutar = Tutar + diger.Tutar }
        : throw new InvalidOperationException("Para birimleri farklı");
}
