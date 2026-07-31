// Kod 4.6 — Dört farklı dönüşüm biçimi
// Tip Dönüşümleri: Implicit, Explicit, Parse ve TryParse

int    sayi   = 42;
long   uzun   = sayi;            // implicit  - veri kaybı yok
double ondalik = 3.99;
int    kirpik = (int)ondalik;    // explicit  - 3 (kesirli kısım atılır)

int a = int.Parse("123");                    // hatalıysa FormatException
bool ok = int.TryParse("abc", out int b);    // ok == false, b == 0

// Kültüre duyarlı ayrıştırma
decimal fiyat = decimal.Parse("1.234,56",
    System.Globalization.CultureInfo.GetCultureInfo("tr-TR"));
