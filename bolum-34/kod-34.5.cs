// Kod 34.5 — İş kuralı testi + uçtan uca test
// Testlerin Eklenmesi

[Fact]
public async Task Olustur_GecmisTarih_HataDoner()
{
    var zaman = new FakeTimeProvider(new DateTimeOffset(2026, 7, 26, 0, 0, 0, TimeSpan.Zero));
    var servis = new GorevServisi(new SahteDepo(), zaman);

    var sonuc = await servis.OlusturAsync(
        new GorevOlusturDto("Test", new DateOnly(2020, 1, 1)), default);

    Assert.False(sonuc.BasariliMi);
}

[Fact]
public async Task Post_GecerliGorev_201Doner()
{
    HttpClient istemci = _fabrika.CreateClient();
    var cevap = await istemci.PostAsJsonAsync("/api/v1/gorevler",
        new { baslik = "Yeni görev" });

    Assert.Equal(HttpStatusCode.Created, cevap.StatusCode);
}
