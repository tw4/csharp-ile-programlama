// Kod 35.2 — Doğru HttpClient kullanımı
// HttpClient ve IHttpClientFactory ile API Tüketimi

builder.Services.AddHttpClient<HavaDurumuIstemcisi>(c =>
{
    c.BaseAddress = new Uri("https://api.ornek.com/");
    c.Timeout = TimeSpan.FromSeconds(10);
});

public sealed class HavaDurumuIstemcisi(HttpClient http)
{
    public async Task<Tahmin?> GetirAsync(string sehir, CancellationToken ct = default)
        => await http.GetFromJsonAsync<Tahmin>($"tahmin?sehir={sehir}", ct);
}
