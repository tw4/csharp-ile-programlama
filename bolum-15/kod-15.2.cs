// Kod 15.2 — Aynı imzayı taşıyan iki arayüzü explicit uygulamak
// Açık (Explicit) Arayüz Uygulaması

public interface IJsonYazdirici
{
    string Yaz();
}

public interface IXmlYazdirici
{
    string Yaz();
}

public sealed class Rapor : IJsonYazdirici, IXmlYazdirici
{
    string IJsonYazdirici.Yaz() => "{ \"ad\": \"Aylik\" }";
    string IXmlYazdirici.Yaz()  => "<rapor ad=\"Aylik\" />";
}

var rapor = new Rapor();
// rapor.Yaz(); // Derleme hatası: public yüzeyde yok

var json = ((IJsonYazdirici)rapor).Yaz();
var xml  = ((IXmlYazdirici)rapor).Yaz();
Console.WriteLine(json);
Console.WriteLine(xml);
