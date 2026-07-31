// Kod 12.6 — Başlatıcılar ve iç içe kullanım
// Nesne ve Koleksiyon Başlatıcıları

var musteri = new Musteri
{
    Ad = "Mert",
    Adres = new Adres { Sehir = "İstanbul", PostaKodu = "34000" },
    Etiketler = { "kurumsal", "öncelikli" },      // koleksiyon başlatıcı
    Siparisler =
    [
        new Siparis("Klavye", 750m),
        new Siparis("Fare", 300m)
    ]
};
