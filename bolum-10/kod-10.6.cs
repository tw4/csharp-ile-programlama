// Kod 10.6 — Türkçe i/I tuzağı
// Biçimlendirme, Kültür ve CultureInfo

string uzanti = "IMAGE";

// Türkçe kültürde çalışan bir makinede:
Console.WriteLine(uzanti.ToLower());              // "ımage"  <- YANLIŞ eşleşir
Console.WriteLine(uzanti.ToLowerInvariant());     // "image"  <- doğru

// Teknik karşılaştırmalarda daima açık kural belirtin:
bool esit = string.Equals(uzanti, "image", StringComparison.OrdinalIgnoreCase);
