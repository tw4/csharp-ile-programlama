// Kod 20.5 — Aggregate ile özel birikim örneği
// Toplama Operatörleri ve Aggregate

var toplam = sepet.Aggregate(
    seed: 0m,
    func: (araToplam, satir) => araToplam + satir.Adet * satir.BirimFiyat);

Console.WriteLine($"Sepet toplamı: {toplam:C}");
