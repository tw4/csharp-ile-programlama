// Kod 5.3 — Kısa devre değerlendirme
// Karşılaştırma ve Mantıksal Operatörler

string? ad = null;

// && ilk koşul false ise ikinciyi HİÇ değerlendirmez
if (ad is not null && ad.Length > 3)
    Console.WriteLine("Uzun ad");

// Sıra değişirse çökerdi:
// if (ad.Length > 3 && ad is not null)   -> NullReferenceException

// || ilk koşul true ise ikinciyi değerlendirmez
bool sonuc = HizliKontrol() || YavasKontrol();
