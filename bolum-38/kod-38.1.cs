// Kod 38.1 — Uzun parametre listesi -> parametre nesnesi
// Kod Kokuları (Code Smells)

// KOKU
void Rapor(string ad, string soyad, DateTime baslangic, DateTime bitis,
           bool detayli, string format, string dil, int sayfa) { }

// TEMİZ
record RaporIstegi(string Ad, string Soyad, DateOnly Baslangic, DateOnly Bitis)
{
    public bool Detayli { get; init; }
    public string Format { get; init; } = "pdf";
}

void Rapor(RaporIstegi istek) { }
