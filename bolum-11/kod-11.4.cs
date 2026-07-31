// Kod 11.4 — Boş/null denetimi ve sıralama karşılaştırması
// Boşluk, Karşılaştırma ve Kontrol Metotları

string.IsNullOrEmpty("")             // True
string.IsNullOrWhiteSpace("   ")     // True  -> tercih edilen kontrol

"elma".CompareTo("armut")            // > 0  (alfabetik sıra)
string.Compare("a", "B", StringComparison.OrdinalIgnoreCase)   // < 0

"abc".Equals("ABC", StringComparison.OrdinalIgnoreCase)        // True
"abc" == "abc"                                                 // True (içerik eşitliği)
