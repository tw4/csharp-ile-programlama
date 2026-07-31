// Kod 10.5 — Kültüre bağlı ve kültürden bağımsız biçimlendirme
// Biçimlendirme, Kültür ve CultureInfo

using System.Globalization;

decimal tutar = 1234.56m;
var tr = CultureInfo.GetCultureInfo("tr-TR");
var en = CultureInfo.GetCultureInfo("en-US");

Console.WriteLine(tutar.ToString("N2", tr));    // 1.234,56
Console.WriteLine(tutar.ToString("N2", en));    // 1,234.56
Console.WriteLine(tutar.ToString("C", tr));     // ₺1.234,56

// Dosyaya / veritabanına / API'ye yazarken kültürden bağımsız olun:
string kayit = tutar.ToString(CultureInfo.InvariantCulture);   // 1234.56
decimal geri = decimal.Parse(kayit, CultureInfo.InvariantCulture);
