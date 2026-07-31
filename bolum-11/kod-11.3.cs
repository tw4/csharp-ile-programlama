// Kod 11.3 — Türkçe’de i/I tuzağı — kültür farkı
// string Metotları: En Çok Kullanılan Üyeler

string kod = "IMAGE";

Console.WriteLine(kod.ToLower());                        // tr-TR'de "ımage"
Console.WriteLine(kod.ToLowerInvariant());               // "image"  <- doğru olan

// Karşılaştırmalarda daima açık kural belirtin:
bool esit = string.Equals("Dosya", "dosya", StringComparison.OrdinalIgnoreCase);
