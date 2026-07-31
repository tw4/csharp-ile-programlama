// Kod 3.6 — Yazdırma seçenekleri ve biçimlendirme
// Konsola Yazma ve Konsoldan Okuma

string ad = "Mert";
decimal tutar = 1250.5m;

Console.WriteLine($"Sayın {ad}, borcunuz {tutar:C} tutarındadır.");
Console.Write("Alt satıra geçmeden yazar. ");
Console.WriteLine();                       // yalnızca boş satır

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Uyarı rengiyle yazıldı");
Console.ResetColor();

// Türkçe karakterlerde sorun yaşarsanız:
Console.OutputEncoding = System.Text.Encoding.UTF8;
