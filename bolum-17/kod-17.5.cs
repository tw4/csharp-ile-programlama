// Kod 17.5 — Generic math ile ortalama hesaplama
// Generic Math ile Sayısal Soyutlama

using System.Numerics;

static T Ortalama<T>(ReadOnlySpan<T> sayilar) where T : INumber<T>
{
    if (sayilar.Length == 0)
        throw new ArgumentException("Dizi boş", nameof(sayilar));

    T toplam = T.Zero;
    foreach (var s in sayilar) toplam += s;
    return toplam / T.CreateChecked(sayilar.Length);
}

Console.WriteLine(Ortalama<int>([10, 20, 30]));         // 20
Console.WriteLine(Ortalama<decimal>([10m, 20m, 30m]));  // 20
