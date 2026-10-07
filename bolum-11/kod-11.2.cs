// Kod 11.2 — Günlük hayatta en sık ihtiyaç duyulan string üyeleri
// string Metotları: En Çok Kullanılan Üyeler

string s = "  C# Programlama  ";

s.Length                     // 18
s.Trim()                     // "C# Programlama"
s.TrimStart(); s.TrimEnd()   // yalnızca baş / son
s.ToUpper(); s.ToLower()     // BÜYÜK / küçük  (kültüre duyarlı!)
s.ToUpperInvariant()         // kültürden bağımsız — karşılaştırmalarda bunu kullanın

s.Contains("Program")        // True
s.StartsWith("  C#")         // True
s.EndsWith("  ")             // True
s.IndexOf('#')               // 3   (bulunamazsa -1)
s.LastIndexOf('a')           // son geçiş
s.Replace("C#", "CSharp")    // yeni bir string döndürür
s.Substring(2, 2)            // "C#"
s.PadLeft(25, '.')           // sola dolgu
s.Insert(0, ">> ");  s.Remove(0, 2);
