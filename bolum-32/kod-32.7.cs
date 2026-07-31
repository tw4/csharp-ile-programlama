// Kod 32.7 — Veritabanı varlığı ile API sözleşmesini ayırmak
// DTO Kullanımı ve Varlıkları Dışa Açmamak

// Varlık — içeride kalır
public class Gorev
{
    public int Id { get; set; }
    public required string Baslik { get; set; }
    public bool Tamamlandi { get; set; }
    public string? IcNot { get; set; }          // dışarı SIZMAMALI
    public DateTime OlusturmaTarihi { get; set; }
}

// Sözleşme — dışarıya açılan
public record GorevDto(int Id, string Baslik, bool Tamamlandi);
public record GorevOlusturDto(string Baslik, DateOnly? Bitis);

// Eşleme
static GorevDto ToDto(Gorev g) => new(g.Id, g.Baslik, g.Tamamlandi);
