// Kod 22.2 — when ile bağlama duyarlı yakalama
// İstisna Filtreleri (when)

try
{
    await DosyaKopyalaAsync(kaynak, hedef, ct);
}
catch (IOException ex) when (ex.Message.Contains("disk", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Disk alanı yetersiz.");
}
catch (IOException ex) when (ex.Message.Contains("erişim", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Dosya erişim izni yok.");
}
