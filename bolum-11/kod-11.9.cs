// Kod 11.9 — Sayı, para ve tarih biçimlendirme kodları
// Biçimlendirme: ToString, string.Format ve Interpolation

decimal tutar = 1234.5678m;

$"{tutar:C}"        // ₺1.234,57   para birimi
$"{tutar:N2}"       // 1.234,57    binlik ayraçlı
$"{tutar:F3}"       // 1234,568    sabit ondalık
$"{0.8567:P1}"      // %85,7       yüzde
$"{42:D5}"          // 00042       basamak doldurma
$"{255:X}"          // FF          onaltılık

DateTime.Now.ToString("dd.MM.yyyy")        // 26.07.2026
DateTime.Now.ToString("HH:mm:ss")          // 14:35:02
DateTime.Now.ToString("dddd, d MMMM yyyy") // Pazar, 26 Temmuz 2026

$"{"sol",-10}|{"sağ",10}|"    // hizalama
