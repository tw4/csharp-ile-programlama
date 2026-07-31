// Kod 24.2 — Eşzamanlı ve asenkron sürümün karşılaştırması
// async ve await’in Çalışma Mantığı

// Engelleyen sürüm: iş parçacığı bekler
string Indir(string url) => new HttpClient().GetStringAsync(url).Result;

// Asenkron sürüm: iş parçacığı serbest kalır
async Task<string> IndirAsync(string url, CancellationToken ct = default)
{
    using var istemci = new HttpClient();
    return await istemci.GetStringAsync(url, ct);
}
