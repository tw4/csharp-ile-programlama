// Kod 6.5 — Nesne özellikleri ve liste yapısı üzerinde eşleme
// Özellik, Liste ve Mantıksal Desenler

record Siparis(string Durum, decimal Tutar, string[] Etiketler);

decimal KargoUcreti(Siparis s) => s switch
{
    { Durum: "iptal" }                    => 0m,
    { Tutar: > 500 }                      => 0m,
    { Etiketler: ["acil", ..] }           => 49.90m,   // ilk eleman "acil"
    { Etiketler: [] }                     => 24.90m,   // boş liste
    _                                     => 19.90m
};
