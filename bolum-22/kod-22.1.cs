// Kod 22.1 — Hata yakalama ve kaynak temizliği
// try, catch, finally ve using

try
{
    using var akis = File.OpenRead("veri.txt");   // blok sonunda otomatik kapanır
    // ... okuma işlemleri
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Dosya bulunamadı: {ex.FileName}");
}
catch (IOException ex) when (ex.HResult == -2147024864)   // istisna filtresi
{
    Console.WriteLine("Dosya başka bir uygulama tarafından kullanılıyor.");
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");       // her durumda çalışır
}
