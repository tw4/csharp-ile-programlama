// Kod 23.2 — Null bağışlamayı kontrollü kullanmak
// null Bağışlama Operatörü (!) ve Riskleri

string? ad = KaynaktanAl();

if (ad is null)
    throw new InvalidOperationException("Ad boş olamaz.");

Console.WriteLine(ad!.Length); // burada mantıksal güvence var
