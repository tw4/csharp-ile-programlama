// Kod 27.2 — Ayırma yapmadan CSV satırı ayrıştırmak
// Span<T>, Memory<T> ve Sıfır Kopya Teknikleri

static int AlanSay(ReadOnlySpan<char> satir)
{
    int adet = 1;
    foreach (char c in satir)
        if (c == ';') adet++;

    return adet;
}

// Substring/Split kullanılmadığı için öbekte (heap) hiçbir tahsis yapılmaz.
Console.WriteLine(AlanSay("ad;soyad;yas"));   // 3
