// Kod 21.1 — Özel delege tanımı ve kullanım
// Delege Kavramı ve Tanımı

public delegate decimal IndirimHesabi(decimal tutar);

static decimal YuzdeOn(decimal t) => t * 0.90m;
static decimal YuzdeYirmi(decimal t) => t * 0.80m;

IndirimHesabi kural = YuzdeOn;
Console.WriteLine(kural(1000m)); // 900

kural = YuzdeYirmi;
Console.WriteLine(kural(1000m)); // 800
