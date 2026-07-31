// Kod 10.1 — Değiştirme yanılsaması
// string Değişmezliği (Immutability)

string ad = "mert";
ad.ToUpper();                    // sonucu kullanmadınız — hiçbir şey değişmedi
Console.WriteLine(ad);           // mert

ad = ad.ToUpper();               // yeni metni geri atadınız
Console.WriteLine(ad);           // MERT

// Referans karşılaştırması
string a = "merhaba";
string b = "merhaba";
Console.WriteLine(a == b);                          // True (içerik eşitliği)
Console.WriteLine(ReferenceEquals(a, b));           // True (aynı nesne!)
