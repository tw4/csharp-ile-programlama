// Kod 26.3 — Büyük dosyaları engellemeden okumak/yazmak
// Asenkron Dosya Erişimi

await File.WriteAllTextAsync("rapor.txt", icerik, ct);

string tamami = await File.ReadAllTextAsync("rapor.txt", ct);

await foreach (string satir in File.ReadLinesAsync("buyuk.csv", ct))
    Isle(satir);
