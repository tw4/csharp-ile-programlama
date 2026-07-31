// Kod 19.5 — Bir kez kurulan, çok okunan arama tabloları
// Frozen Koleksiyonlar ile Salt Okunur Performans

using System.Collections.Frozen;

private static readonly FrozenDictionary<string, string> UlkeKodlari =
    new Dictionary<string, string>
    {
        ["TR"] = "Türkiye",
        ["DE"] = "Almanya",
        ["FR"] = "Fransa"
    }.ToFrozenDictionary();

// Kurulum maliyeti bir kez ödenir; okuma Dictionary'den belirgin biçimde hızlıdır.
Console.WriteLine(UlkeKodlari["TR"]);
