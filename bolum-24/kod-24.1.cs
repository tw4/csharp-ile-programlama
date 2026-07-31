// Kod 24.1 — Task ile CPU yoğun bir işi planlamak
// Thread, ThreadPool ve Task Temelleri

int sonuc = await Task.Run(() =>
{
    int toplam = 0;
    for (int i = 1; i <= 1_000_000; i++) toplam += i;
    return toplam;
});

Console.WriteLine(sonuc);
