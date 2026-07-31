// Kod 22.3 — Alana özgü istisna tipi
// Özel İstisna Sınıfları Yazmak

public sealed class YetersizBakiyeException(decimal istenen, decimal mevcut)
    : Exception($"Yetersiz bakiye. İstenen: {istenen:C}, mevcut: {mevcut:C}")
{
    public decimal Istenen { get; } = istenen;
    public decimal Mevcut  { get; } = mevcut;
}

// Kullanımı
if (tutar > bakiye) throw new YetersizBakiyeException(tutar, bakiye);
