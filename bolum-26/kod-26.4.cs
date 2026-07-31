// Kod 26.4 — Nesne <-> JSON dönüşümü
// System.Text.Json ile Serileştirme

using System.Text.Json;

var secenekler = new JsonSerializerOptions
{
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

var urun = new Urun { Ad = "Klavye", Fiyat = 750m };
string json = JsonSerializer.Serialize(urun, secenekler);

Urun? geri = JsonSerializer.Deserialize<Urun>(json, secenekler);
