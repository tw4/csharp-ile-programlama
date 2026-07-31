// Kod 9.6 — Özyineleme: faktöriyel ve klasör gezme
// Özyineleme (Recursion)

static long Faktoriyel(int n)
{
    if (n <= 1) return 1;            // taban durum — özyinelemeyi durdurur
    return n * Faktoriyel(n - 1);    // özyinelemeli adım
}

static long ToplamBoyut(DirectoryInfo klasor)
{
    long toplam = klasor.GetFiles().Sum(f => f.Length);

    foreach (var alt in klasor.GetDirectories())
        toplam += ToplamBoyut(alt);   // her alt klasör için aynı iş

    return toplam;
}
