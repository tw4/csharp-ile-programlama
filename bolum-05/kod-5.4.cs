// Kod 5.4 — Bayrakları bit düzeyinde yönetmek
// Bit Düzeyi Operatörler

int izinler = 0b0000;
const int Okuma = 0b0001, Yazma = 0b0010, Silme = 0b0100;

izinler |= Okuma | Yazma;                     // izin ekle
bool yazabilir = (izinler & Yazma) == Yazma;  // izin sorgula
izinler &= ~Yazma;                            // izin kaldır

Console.WriteLine(Convert.ToString(izinler, 2).PadLeft(4, '0')); // 0001
