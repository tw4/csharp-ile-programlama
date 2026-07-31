// Kod 21.5 — Olay tanımlama, tetikleme ve abone olma
// Olaylar (Events) ve Yayıncı-Abone Modeli

public sealed class StokTakip
{
    public event EventHandler<StokAzaldiEventArgs>? StokAzaldi;

    private int _adet = 10;

    public void Sat(int miktar)
    {
        _adet -= miktar;
        if (_adet < 3)
            StokAzaldi?.Invoke(this, new StokAzaldiEventArgs(_adet));
    }
}

public sealed class StokAzaldiEventArgs(int kalan) : EventArgs
{
    public int Kalan { get; } = kalan;
}

var takip = new StokTakip();
takip.StokAzaldi += (s, e) => Console.WriteLine($"Uyarı! Kalan: {e.Kalan}");
takip.Sat(8);   // Uyarı! Kalan: 2
