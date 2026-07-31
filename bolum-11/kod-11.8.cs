// Kod 11.8 — Hangisi ne zaman kullanılır
// Dönüştürme: Parse, TryParse ve Convert

int.Parse("42")                     // hata varsa istisna fırlatır
int.TryParse(girdi, out int deger)  // güvenli — kullanıcı girdisinde bunu kullanın
Convert.ToInt32("42")               // null'ı 0'a çevirir, istisna da fırlatabilir

double.TryParse("3,14", out double d)          // mevcut kültüre göre
double.TryParse("3.14", CultureInfo.InvariantCulture, out d)   // sabit kültür

bool.TryParse("true", out bool bayrak)
DateTime.TryParse("26.07.2026", out DateTime t)
Enum.TryParse<Izinler>("Okuma", out var izin)

Convert.ToString(255, 2)      // "11111111"  ikilik tabana
Convert.ToInt32("FF", 16)     // 255         onaltılıktan
