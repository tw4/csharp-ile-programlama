// Kod 15.4 — Tipten bağımsız sayısal algoritma
// static abstract Üyeler ve Genel Matematik (Generic Math)

using System.Numerics;

static T Toplam<T>(IEnumerable<T> sayilar) where T : INumber<T>
{
    T toplam = T.Zero;
    foreach (T s in sayilar) toplam += s;
    return toplam;
}

Console.WriteLine(Toplam([1, 2, 3]));            // int    -> 6
Console.WriteLine(Toplam([1.5, 2.5]));           // double -> 4
Console.WriteLine(Toplam([10.5m, 20.25m]));      // decimal-> 30,75
