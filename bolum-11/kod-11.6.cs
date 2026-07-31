// Kod 11.6 — En çok kullanılan Math üyeleri
// Sayısal İşlemler: Math Sınıfı

Math.Abs(-7)              // 7        mutlak değer
Math.Max(3, 9)            // 9
Math.Min(3, 9)            // 3
Math.Pow(2, 10)           // 1024     üs alma
Math.Sqrt(144)            // 12       karekök
Math.Round(2.567, 2)      // 2,57     yuvarlama
Math.Round(2.5)           // 2        (bankacı yuvarlaması!)
Math.Round(2.5, MidpointRounding.AwayFromZero)   // 3
Math.Floor(2.9)           // 2        aşağı
Math.Ceiling(2.1)         // 3        yukarı
Math.Truncate(-2.9)       // -2       kesme
Math.Clamp(150, 0, 100)   // 100      aralığa sıkıştır
Math.Sign(-42)            // -1
