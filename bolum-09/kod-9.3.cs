// Kod 9.3 — Parametre değiştiricilerinin karşılaştırması
// ref, out, in ve ref readonly Parametreler

void IkiyeKatla(ref int sayi) => sayi *= 2;           // giriş+çıkış
bool Bol(int a, int b, out int sonuc)                  // yalnızca çıkış
{
    sonuc = b == 0 ? 0 : a / b;
    return b != 0;
}
double Uzunluk(in Nokta3B v)       // salt okunur giriş
    => Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);

int x = 5;
IkiyeKatla(ref x);              // x == 10
if (Bol(10, 2, out int bolum))
    Console.WriteLine(bolum);   // 5
