// Kod 25.1 — CPU ve G/Ç yoğun işlerin paralelleştirilmesi
// Parallel.For, Parallel.ForEach ve ForEachAsync

// CPU yoğun
Parallel.For(0, 1_000, i => AgirHesap(i));

// G/Ç yoğun, eşzamanlılık sınırlı
await Parallel.ForEachAsync(
    urlListesi,
    new ParallelOptions { MaxDegreeOfParallelism = 8 },
    async (url, ct) =>
    {
        var icerik = await IndirAsync(url, ct);
        await KaydetAsync(icerik, ct);
    });
