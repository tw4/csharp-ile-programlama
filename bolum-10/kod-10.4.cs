// Kod 10.4 — Döngü içinde + yerine StringBuilder
// StringBuilder ile Verimli Metin Birleştirme

// KÖTÜ: her adımda yeni string üretilir
string rapor = "";
for (int i = 0; i < 10_000; i++) rapor += i + ";";

// İYİ: tek tampon üzerinde çalışır
var sb = new System.Text.StringBuilder();
for (int i = 0; i < 10_000; i++) sb.Append(i).Append(';');
string hizliRapor = sb.ToString();
