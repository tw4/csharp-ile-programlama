// Kod 14.3 — new ile üye gizleme davranışı
// virtual, override ve new

public class Raporlayici
{
    public virtual string Format() => "Temel rapor";
}

public class JsonRaporlayici : Raporlayici
{
    public new string Format() => "JSON rapor";   // override değil, gizleme
}

Raporlayici r = new JsonRaporlayici();
Console.WriteLine(r.Format());                    // Temel rapor
Console.WriteLine(((JsonRaporlayici)r).Format()); // JSON rapor
