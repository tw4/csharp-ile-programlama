// Kod 10.3 — Kaçış karakteri olmadan JSON yazmak
// String Interpolation ve Ham Metin Değişmezleri

string ad = "Mert";
string json = $$"""
{
    "ad": "{{ad}}",
    "aktif": true,
    "yol": "C:\\Projeler\\Kitap"
}
""";

Console.WriteLine(json);

// Ham metin değişmezinde kaçış karakteri yoktur; $$ ile enterpolasyon
// belirteci {{ }} olur, böylece JSON süslü parantezleri serbest kalır.
