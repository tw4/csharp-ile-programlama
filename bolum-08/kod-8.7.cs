// Kod 8.7 — Koleksiyon ifadelerinin pratik kullanımları
// Koleksiyon İfadeleri ve Spread Operatörü

// Boş koleksiyon
int[] bos = [];

// Metot parametresinde
Isle([1, 2, 3]);

// Koşullu birleştirme
string[] temel = ["ad", "soyad"];
string[] tumAlanlar = detayliMi ? [..temel, "adres", "telefon"] : temel;

// İç içe
int[][] matris = [[1, 2], [3, 4]];
