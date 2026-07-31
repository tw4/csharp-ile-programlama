// Kod 9.2 — Varsayılan değerler ve isimlendirilmiş argümanlar
// İsimlendirilmiş ve İsteğe Bağlı Parametreler

void Rapor(string baslik,
           bool detayli = false,
           string format = "pdf",
           int sayfa = 1)
{ }

Rapor("Aylık Satış");                          // diğerleri varsayılan
Rapor("Aylık Satış", true);                    // detaylı
Rapor("Aylık Satış", format: "html");          // sırayı atlayarak
Rapor(baslik: "Aylık Satış", sayfa: 3);        // isimlendirilmiş
