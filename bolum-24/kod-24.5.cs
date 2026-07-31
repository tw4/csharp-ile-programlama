// Kod 24.5 — Akış hâlinde asenkron veri üretmek
// IAsyncEnumerable ve await foreach

async IAsyncEnumerable<string> SatirlariOkuAsync(
    string yol,
    [EnumeratorCancellation] CancellationToken ct = default)
{
    using var okuyucu = new StreamReader(yol);
    while (await okuyucu.ReadLineAsync(ct) is { } satir)
        yield return satir;
}

await foreach (string satir in SatirlariOkuAsync("kayit.log"))
    Console.WriteLine(satir);
