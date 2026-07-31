// Kod 10.7 — Temel Regex kullanımları
// Düzenli İfadeler (Regex) ve Kaynak Üreteçli Regex

using System.Text.RegularExpressions;

string metin = "Sipariş 1024 tarihi 26.07.2026, tutar 1500 TL";

// Eşleşme var mı?
bool varMi = Regex.IsMatch(metin, @"\d{2}\.\d{2}\.\d{4}");

// Tek eşleşme
Match m = Regex.Match(metin, @"(?<gun>\d{2})\.(?<ay>\d{2})\.(?<yil>\d{4})");
if (m.Success)
    Console.WriteLine($"{m.Groups["yil"].Value} yılı");

// Tüm sayıları bul
foreach (Match sayi in Regex.Matches(metin, @"\d+"))
    Console.Write($"{sayi.Value} ");        // 1024 26 07 2026 1500

// Değiştir
string gizli = Regex.Replace(metin, @"\d+", "***");
