// Kod 29.3 — Null denetimini tek satıra indirmek
// null Koşullu Atama (?.= )

// Eski yazım
if (musteri is not null) musteri.Siparis = yeniSiparis;

// C# 14
musteri?.Siparis = yeniSiparis;    // musteri null ise sağ taraf değerlendirilmez
