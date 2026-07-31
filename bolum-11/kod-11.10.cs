// Kod 11.10 — En çok kullanılan tarih işlemleri
// Tarih ve Saat: DateTime, DateOnly, TimeSpan

DateTime.Now          // yerel saat
DateTime.UtcNow       // UTC — veritabanına bunu yazın
DateTime.Today        // saat 00:00
DateOnly.FromDateTime(DateTime.Now)        // yalnızca tarih
TimeOnly.FromDateTime(DateTime.Now)        // yalnızca saat

var t = new DateTime(2026, 7, 26);
t.AddDays(10); t.AddMonths(-1); t.AddYears(1);
t.DayOfWeek                                 // Sunday
t.DayOfYear                                 // 207
DateTime.DaysInMonth(2026, 2)               // 28
DateTime.IsLeapYear(2028)                   // True

TimeSpan fark = DateTime.Now - t;
Console.WriteLine($"{fark.TotalDays:F0} gün geçti");
