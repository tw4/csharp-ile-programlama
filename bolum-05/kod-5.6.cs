// Kod 5.6 — Varsayılan değer atama kalıpları
// null Birleştirme Operatörleri (??, ??=)

string? girdi = null;

string ad = girdi ?? "İsimsiz";   // null ise varsayılan
girdi ??= "Varsayılan";           // yalnızca null ise ata

List<string>? liste = null;
(liste ??= new()).Add("ilk eleman");  // gerektiğinde oluştur
