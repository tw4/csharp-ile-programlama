// Kod 7.6 — break ve continue
// break, continue ve goto

int[] sayilar = [4, 8, -1, 15, 23];

foreach (int s in sayilar)
{
    if (s < 0) continue;          // negatifleri atla
    if (s > 20) break;            // 20'yi aşınca dur

    Console.Write($"{s} ");       // 4 8 15
}

// Aradığını bulunca durmak yaygın bir kalıptır:
int aranan = 15, bulunanIndeks = -1;
for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] == aranan) { bulunanIndeks = i; break; }
}
