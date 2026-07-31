// Kod 6.7 — Koşulu adlandırmak
// Kaçınılması Gereken Karmaşık Koşullar

// Okunması zor
if (musteri.Yas >= 18 && musteri.Bakiye > 0 && !musteri.Engelli && musteri.Onayli)
{ }

// Niyeti açık
bool yetiskin      = musteri.Yas >= 18;
bool hesapKullanilabilir = musteri.Bakiye > 0 && !musteri.Engelli;
bool islemYapabilir = yetiskin && hesapKullanilabilir && musteri.Onayli;

if (islemYapabilir) { }
