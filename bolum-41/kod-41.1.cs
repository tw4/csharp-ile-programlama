// Kod 41.1 — SQL enjeksiyonundan korunmak
// Girdi Doğrulama ve Enjeksiyon Saldırıları

// TEHLİKELİ: kullanıcı girdisi doğrudan sorguya gömülüyor
var sql = $"SELECT * FROM Kullanicilar WHERE Ad = '{ad}'";

// GÜVENLİ: parametreli sorgu
await using var cmd = new SqlCommand(
    "SELECT * FROM Kullanicilar WHERE Ad = @ad", conn);
cmd.Parameters.AddWithValue("@ad", ad);

// EF Core zaten parametreleştirir:
var k = await db.Kullanicilar.Where(x => x.Ad == ad).ToListAsync();
