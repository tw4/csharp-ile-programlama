// Kod 10.8 — Derleme zamanında üretilen, hızlı Regex
// Düzenli İfadeler (Regex) ve Kaynak Üreteçli Regex

using System.Text.RegularExpressions;

public static partial class Dogrulayici
{
    [GeneratedRegex(@"^[\w\.\-]+@[\w\-]+\.[a-zA-Z]{2,}$",
                    RegexOptions.IgnoreCase)]
    public static partial Regex EPosta();
}

Console.WriteLine(Dogrulayici.EPosta().IsMatch("mert@ornek.com")); // True
