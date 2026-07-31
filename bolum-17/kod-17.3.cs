// Kod 17.3 — in / out ile varyans örneği
// Kovaryans ve Kontravaryans (in / out)

public interface IOkuyucu<out T>
{
    T Oku();
}

public interface IYazici<in T>
{
    void Yaz(T veri);
}

IOkuyucu<string> metinOkuyucu = new DosyaMetinOkuyucu();
IOkuyucu<object> nesneOkuyucu = metinOkuyucu; // out: mümkün

IYazici<object> nesneYazici = new KonsolYazici();
IYazici<string> metinYazici = nesneYazici;    // in: mümkün
