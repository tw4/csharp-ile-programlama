// Kod 19.4 — ImmutableList ile güvenli güncelleme
// Değişmez Koleksiyonlar (System.Collections.Immutable)

using System.Collections.Immutable;

ImmutableList<string> roller = ["Yazar", "Editör"];
var yeni = roller.Add("Okur");

Console.WriteLine(string.Join(", ", roller)); // Yazar, Editör
Console.WriteLine(string.Join(", ", yeni));   // Yazar, Editör, Okur
