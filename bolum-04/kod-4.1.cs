// Kod 4.1 — Kopyalama davranışındaki fark
// Değer Tipleri ve Referans Tipleri

struct Nokta { public int X; public int Y; }
class  Kutu   { public int Genislik; }

var n1 = new Nokta { X = 1, Y = 2 };
var n2 = n1;             // DEĞER kopyalanır
n2.X = 99;
Console.WriteLine(n1.X); // 1  -> n1 etkilenmedi

var k1 = new Kutu { Genislik = 10 };
var k2 = k1;             // REFERANS kopyalanır
k2.Genislik = 99;
Console.WriteLine(k1.Genislik); // 99 -> aynı nesne
