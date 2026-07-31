// Kod 11.17 — Konsol uygulamalarında işe yarayan üyeler
// Console Sınıfının Pratik Üyeleri

Console.WriteLine("satır");     Console.Write("satır sonu yok");
Console.ReadLine();             Console.ReadKey(intercept: true);
Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Başarılı");
Console.ResetColor();

Console.Error.WriteLine("Hata akışına yazar");    // stderr
Console.OutputEncoding = System.Text.Encoding.UTF8;   // Türkçe karakterler için
