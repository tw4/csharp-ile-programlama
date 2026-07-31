// Kod 11.11 — Yaş hesaplama — klasik alıştırma
// Tarih ve Saat: DateTime, DateOnly, TimeSpan

static int YasHesapla(DateOnly dogum)
{
    var bugun = DateOnly.FromDateTime(DateTime.Today);
    int yas = bugun.Year - dogum.Year;
    if (dogum > bugun.AddYears(-yas)) yas--;   // doğum günü henüz gelmediyse
    return yas;
}
