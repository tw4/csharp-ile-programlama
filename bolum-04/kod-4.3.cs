// Kod 4.3 — Üç temel tipin kullanımı
// bool, char ve string

bool aktifMi = true;
char harf = 'M';
string ad = "Mert";

Console.WriteLine(ad.Length);        // 4
Console.WriteLine(ad[0]);            // M   (char döner)
Console.WriteLine(ad + " " + harf);  // Mert M

// Boş metin ile null farklıdır:
string bos = "";        // uzunluğu 0 olan geçerli bir metin
string? yok = null;     // hiçbir metin yok
