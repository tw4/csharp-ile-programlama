// Kod 7.5 — Kendi numaralandırılabilir tipinizi yazmak
// foreach ve IEnumerable İlişkisi

IEnumerable<int> FibonacciUret(int adet)
{
    (int onceki, int simdiki) = (0, 1);
    for (int i = 0; i < adet; i++)
    {
        yield return simdiki;                       // tembel üretim
        (onceki, simdiki) = (simdiki, onceki + simdiki);
    }
}

foreach (int sayi in FibonacciUret(8))
    Console.Write($"{sayi} ");     // 1 1 2 3 5 8 13 21
