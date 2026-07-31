// Kod 29.2 — Arka alan (backing field) tanımlamadan doğrulama
// field Anahtar Sözcüğü ile Yarı Otomatik Özellikler

public class Ayar
{
    // Ayrı bir _zamanAsimi alanı tanımlamaya gerek yok
    public int ZamanAsimi
    {
        get => field;
        set => field = value < 1 ? 30 : value;
    } = 30;
}
