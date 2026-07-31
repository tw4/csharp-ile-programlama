// Kod 12.9 — Nesne erişilemez hâle geliyor
// Nesne Yaşam Döngüsü ve Çöp Toplayıcıya (GC) Bakış

var m = new Musteri();       // nesne öbekte oluştu
m = null;                    // artık kimse göstermiyor -> toplanabilir

{
    var gecici = new Musteri();
}                            // blok bitti, gecici kapsam dışı -> toplanabilir
