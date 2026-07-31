// Kod 9.7 — Yalnızca tek bir metotta kullanılan yardımcı mantık
// Yerel Fonksiyonlar ve İfade Gövdeli Üyeler

int FaktoriyelHesapla(int n)
{
    ArgumentOutOfRangeException.ThrowIfNegative(n);
    return Hesapla(n);

    static int Hesapla(int k) => k <= 1 ? 1 : k * Hesapla(k - 1);
}
