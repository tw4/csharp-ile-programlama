// Kod 24.1 — Task ile CPU yoğun bir işi planlamak
// Thread, ThreadPool ve Task Temelleri

long sonuc = await Task.Run(() =>
{
    long toplam = 0;   // int taşar: sonuç 500.000.500.000
    for (int i = 1; i <= 1_000_000; i++) toplam += i;
    return toplam;
});

Console.WriteLine(sonuc);
