// Kod 12.5 — required ile zorunlu alanlar
// Özellikler (Properties), get/set ve init

public class Kullanici
{
    public required string Eposta { get; init; }
    public required string Ad { get; init; }
    public string? Telefon { get; init; }          // isteğe bağlı
}

var k = new Kullanici { Eposta = "a@b.com", Ad = "Mert" };
// var hatali = new Kullanici { Ad = "Mert" };   // HATA: Eposta atanmadı
