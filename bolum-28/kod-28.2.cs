// Kod 28.2 — Elle yazılan kodu derleyiciye yazdırmak
// Kaynak Üreteçleri (Source Generators) ile Derleme Zamanı Kod Üretimi

// Kaynak üretecinin ürettiği kod (elle yazılmaz):
partial class Musteri
{
    public string ToCsv() => $"{Id};{Ad};{Eposta}";
}

// Kullanıcının yazdığı tek şey:
[CsvSerializable]
public partial class Musteri
{
    public int Id { get; set; }
    public string Ad { get; set; } = "";
    public string Eposta { get; set; } = "";
}
