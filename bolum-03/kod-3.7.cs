// Kod 3.7 — Üç yorum türü bir arada
// Yorum Satırları ve XML Dokümantasyon Yorumları

// Tek satırlık yorum — en sık kullanılanı

/* Birden fazla satıra yayılan
   açıklamalar için kullanılır. */

/// <summary>
/// İki tarih arasındaki iş günü sayısını hesaplar.
/// </summary>
/// <param name="baslangic">Hesaplamaya dâhil edilen ilk gün.</param>
/// <param name="bitis">Hesaplamaya dâhil edilen son gün.</param>
/// <returns>Hafta sonları hariç toplam gün sayısı.</returns>
/// <exception cref="ArgumentException">Bitiş, başlangıçtan önceyse fırlatılır.</exception>
public static int IsGunuSay(DateOnly baslangic, DateOnly bitis)
{
    if (bitis < baslangic)
        throw new ArgumentException("Bitiş tarihi başlangıçtan önce olamaz.");

    int sayac = 0;
    for (var gun = baslangic; gun <= bitis; gun = gun.AddDays(1))
        if (gun.DayOfWeek is not (DayOfWeek.Saturday or DayOfWeek.Sunday))
            sayac++;

    return sayac;
}
