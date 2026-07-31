// Kod 7.7 — İç içe döngü: çarpım tablosu
// İç İçe Döngüler ve Performans Notları

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
        Console.Write($"{i * j,4}");

    Console.WriteLine();
}
