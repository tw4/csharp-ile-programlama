// Kod 7.1 — Klasik sayaçlı döngü
// for Döngüsü

for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0) continue;      // çiftleri atla
    Console.WriteLine($"{i} tek sayı");
}
