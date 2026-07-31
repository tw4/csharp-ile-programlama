// Kod 12.7 — this'in üç kullanımı
// this Anahtar Sözcüğü

public class Kutu
{
    private int genislik, yukseklik;

    // 1) Ad çakışmasını çözmek
    public Kutu(int genislik, int yukseklik)
    {
        this.genislik = genislik;
        this.yukseklik = yukseklik;
    }

    // 2) Başka bir yapıcıyı çağırmak
    public Kutu(int kenar) : this(kenar, kenar) { }

    // 3) Zincirleme için nesnenin kendisini döndürmek
    public Kutu Genislet(int miktar)
    {
        genislik += miktar;
        return this;
    }
}

var k = new Kutu(10).Genislet(5).Genislet(3);   // akıcı zincir
