// Kod 6.4 — Tip deseni ve ilişkisel desenler
// switch İfadesi ve Desen Eşleme (Pattern Matching)

static string Tanimla(object deger) => deger switch
{
    null              => "değer yok",
    int n when n < 0  => $"negatif tam sayı: {n}",
    int n             => $"tam sayı: {n}",
    double d          => $"ondalıklı: {d:F2}",
    string { Length: 0 } => "boş metin",
    string s          => $"metin ({s.Length} karakter)",
    _                 => $"bilinmeyen tip: {deger.GetType().Name}"
};
