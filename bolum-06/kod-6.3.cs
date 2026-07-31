// Kod 6.3 — switch deyimi yerine switch ifadesi
// switch İfadesi ve Desen Eşleme (Pattern Matching)

string Kategori(int yas) => yas switch
{
    < 0        => throw new ArgumentOutOfRangeException(nameof(yas)),
    < 13       => "Çocuk",
    >= 13 and < 18 => "Genç",
    >= 18 and < 65 => "Yetişkin",
    _          => "Kıdemli"
};

Console.WriteLine(Kategori(30)); // Yetişkin
