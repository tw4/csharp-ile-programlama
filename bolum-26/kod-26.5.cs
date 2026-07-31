// Kod 26.5 — Yansımasız, AOT uyumlu ve hızlı serileştirme
// Kaynak Üreteçli JSON Serileştirme (Source Generation)

using System.Text.Json.Serialization;

[JsonSourceGenerationOptions(WriteIndented = true,
                             PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(Urun))]
[JsonSerializable(typeof(List<Urun>))]
internal partial class UrunJsonContext : JsonSerializerContext;

string json = JsonSerializer.Serialize(urun, UrunJsonContext.Default.Urun);
