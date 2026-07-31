// Kod 36.3 — API'yi baştan sona test etmek
// Entegrasyon Testleri ve WebApplicationFactory

public class YaziApiTestleri(WebApplicationFactory<Program> fabrika)
    : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task GetYazilar_BasariliDoner()
    {
        HttpClient istemci = fabrika.CreateClient();
        HttpResponseMessage cevap = await istemci.GetAsync("/yazilar");

        cevap.EnsureSuccessStatusCode();
        Assert.Equal("application/json",
            cevap.Content.Headers.ContentType?.MediaType);
    }
}
