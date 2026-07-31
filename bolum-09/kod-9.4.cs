// Kod 9.4 — C# 13 ile params artık Span ve List de kabul ediyor
// params Dizileri ve params Koleksiyonları

int Topla(params ReadOnlySpan<int> sayilar)   // dizi ayırma yok
{
    int toplam = 0;
    foreach (int s in sayilar) toplam += s;
    return toplam;
}

Console.WriteLine(Topla(1, 2, 3, 4));   // 10
Console.WriteLine(Topla());             // 0
