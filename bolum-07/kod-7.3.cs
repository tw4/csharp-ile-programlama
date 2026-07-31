// Kod 7.3 — while ve do-while karşılaştırması
// while ve do-while

// while — koşul başta
int sayi = 100;
while (sayi > 1)
{
    sayi /= 2;
    Console.Write($"{sayi} ");     // 50 25 12 6 3 1
}

// do-while — gövde en az bir kez çalışır
string? girdi;
do
{
    Console.Write("Komut (çıkmak için 'q'): ");
    girdi = Console.ReadLine();
    Console.WriteLine($"Aldım: {girdi}");
}
while (girdi != "q");
