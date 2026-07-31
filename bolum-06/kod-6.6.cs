// Kod 6.6 — Mantıksal ve ilişkisel desenler
// Özellik, Liste ve Mantıksal Desenler

bool CalismaSaati(int saat) => saat is >= 9 and < 18;

bool HaftaSonu(DayOfWeek g) => g is DayOfWeek.Saturday or DayOfWeek.Sunday;

bool GecerliPuan(int p) => p is not (< 0 or > 100);

// Klasik yazımla karşılaştırın:
// bool CalismaSaati(int saat) => saat >= 9 && saat < 18;
