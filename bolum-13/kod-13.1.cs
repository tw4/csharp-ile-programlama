// Kod 13.1 — C# 14: field anahtar sözcüğü ile yarı otomatik özellik
// Doğrulama Mantığını Özelliklerde Yönetmek

public class Musteri
{
    public string Eposta
    {
        get => field;
        set => field = string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentException("E-posta boş olamaz", nameof(value))
            : value.Trim().ToLowerInvariant();
    } = "bilinmiyor@ornek.com";
}
