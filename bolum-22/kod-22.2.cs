// Kod 22.2 — when ile bağlama duyarlı yakalama
// İstisna Filtreleri (when)

// Windows HResult kodları; ileti metni dile göre değişir
const int DiskDolu = unchecked((int)0x80070070);
const int PaylasimIhlali = unchecked((int)0x80070020);

try
{
    await DosyaKopyalaAsync(kaynak, hedef, ct);
}
catch (IOException ex) when (ex.HResult == DiskDolu)
{
    Console.WriteLine("Disk alanı yetersiz.");
}
catch (IOException ex) when (ex.HResult == PaylasimIhlali)
{
    Console.WriteLine("Dosya başka bir işlemde açık.");
}
catch (UnauthorizedAccessException)   // IOException değildir
{
    Console.WriteLine("Dosya erişim izni yok.");
}
