// Kod 9.5 — Aşırı yüklenmiş metotlar
// Metot Aşırı Yükleme (Overloading)

public static string Bicimle(int sayi) => sayi.ToString("N0");
public static string Bicimle(decimal tutar) => tutar.ToString("C");
public static string Bicimle(DateTime tarih) => tarih.ToString("dd.MM.yyyy");
public static string Bicimle(decimal tutar, string paraBirimi)
    => $"{tutar:N2} {paraBirimi}";

Console.WriteLine(Bicimle(1500));            // 1.500
Console.WriteLine(Bicimle(1500m));           // ₺1.500,00
Console.WriteLine(Bicimle(1500m, "USD"));    // 1.500,00 USD
