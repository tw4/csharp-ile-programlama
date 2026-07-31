// Kod 25.2 — PLINQ ile CPU yoğun filtreleme
// PLINQ ile Paralel Sorgular

var asalSayilar = Enumerable.Range(2, 1_000_000)
    .AsParallel()
    .WithDegreeOfParallelism(Environment.ProcessorCount)
    .Where(AsalMi)
    .ToArray();

static bool AsalMi(int sayi) => sayi > 1 &&
    Enumerable.Range(2, (int)Math.Sqrt(sayi) - 1).All(bolen => sayi % bolen != 0);
