// Kod 22.5 — Modern koruma (guard) yardımcıları
// ArgumentNullException.ThrowIfNull ve Guard Yaklaşımı

public void Kaydet(string ad, int adet, Stream icerik)
{
    ArgumentException.ThrowIfNullOrWhiteSpace(ad);
    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(adet);
    ArgumentNullException.ThrowIfNull(icerik);
    ObjectDisposedException.ThrowIf(_kapatildi, this);

    // ... asıl iş buradan sonra başlar
}
