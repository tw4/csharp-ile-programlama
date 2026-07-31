// Kod 20.6 — Gruplamadan sayma ve indeksli döngü
// Modern LINQ Operatörleri: CountBy, AggregateBy, Index

string[] kelimeler = ["elma", "armut", "elma", "kiraz", "armut", "elma"];

foreach (var (kelime, adet) in kelimeler.CountBy(k => k))
    Console.WriteLine($"{kelime}: {adet}");       // elma: 3, armut: 2, kiraz: 1

foreach (var (sira, kelime) in kelimeler.Distinct().Index())
    Console.WriteLine($"{sira}. {kelime}");        // 0. elma, 1. armut, 2. kiraz
