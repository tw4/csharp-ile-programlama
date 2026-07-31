// Kod 14.5 — sealed sınıf ve sealed override
// sealed ile Kalıtımı Kapatmak

public class MesajGonderici
{
    public virtual string Kanal() => "Genel";
}

public class EPostaGonderici : MesajGonderici
{
    public sealed override string Kanal() => "E-Posta";
}

// public class OzelGonderici : EPostaGonderici { } // Derleme hatası: sealed override genişletilemez
