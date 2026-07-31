// Kod 15.3 — Varsayılan davranışla arayüzü genişletmek
// Varsayılan Arayüz Metotları

public interface IOnbellek
{
    string? Getir(string anahtar);
    void Kaydet(string anahtar, string deger);

    // Sonradan eklendi; eski uygulamalar bozulmaz
    bool Icerir(string anahtar) => Getir(anahtar) is not null;
}

public sealed class BellekOnbellek : IOnbellek
{
    private readonly Dictionary<string, string> _veri = [];
    public string? Getir(string anahtar) => _veri.GetValueOrDefault(anahtar);
    public void Kaydet(string anahtar, string deger) => _veri[anahtar] = deger;
}

IOnbellek onbellek = new BellekOnbellek();
onbellek.Kaydet("kullanici:1", "Mert");
Console.WriteLine(onbellek.Icerir("kullanici:1")); // True
