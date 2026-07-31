// Kod 5.7 — Koşullu operatör ve koleksiyon ifadeleri
// Koşullu Operatör ve Koleksiyon İfadeleri

int a = 12, b = 7;
int buyuk = a > b ? a : b;                   // 12

string durum = puan >= 50 ? "Geçti" : "Kaldı";

// İç içe kullanım okunaklılığı bozar; switch ifadesini tercih edin:
string harf = puan >= 85 ? "A" : puan >= 70 ? "B" : "C";

// Koleksiyon ifadeleri (C# 12): köşeli parantezle koleksiyon oluşturma
int[]     dizi  = [1, 2, 3];
List<int> liste = [4, 5, 6];
int[]     hepsi = [..dizi, ..liste, 99];     // spread
