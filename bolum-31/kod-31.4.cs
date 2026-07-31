// Kod 31.4 — Ham SQL ile hızlı okuma
// Dapper ile Hafif Veri Erişimi

using Dapper;

await using var conn = new SqlConnection(baglantiMetni);

var sonuc = await conn.QueryAsync<Yazi>(
    "SELECT Id, Icerik FROM Yazilar WHERE BlogId = @blogId",
    new { blogId = 1 });
