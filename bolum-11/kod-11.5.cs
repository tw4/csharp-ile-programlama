// Kod 11.5 — Metni parçalamak ve yeniden birleştirmek
// Metin Bölme ve Birleştirme: Split, Join, Concat

string csv = "mert;türkoğlu;;istanbul";

string[] alanlar = csv.Split(';');                                  // 4 parça
string[] dolular = csv.Split(';', StringSplitOptions.RemoveEmptyEntries
                                | StringSplitOptions.TrimEntries);  // 3 parça

string geri = string.Join(" | ", dolular);   // "mert | türkoğlu | istanbul"
string tek  = string.Concat("a", "b", "c");  // "abc"

// Satırlara bölmek (platformdan bağımsız)
string[] satirlar = metin.Split(Environment.NewLine);
