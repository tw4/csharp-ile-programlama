// Kod 11.1 — Aynı işin iki yazımı
// Neden Hazır Fonksiyonları Bilmek Gerekir

int[] sayilar = [5, 3, 9, 1, 7];

// Elle
int enBuyuk = sayilar[0];
for (int i = 1; i < sayilar.Length; i++)
    if (sayilar[i] > enBuyuk) enBuyuk = sayilar[i];

// Hazır
int enBuyuk2 = sayilar.Max();
