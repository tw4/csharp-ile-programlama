// Kod 8.1 — Dizi oluşturmanın farklı yolları
// Tek Boyutlu Diziler

int[] bos = new int[5];                 // 5 elemanlı, hepsi 0
int[] sayilar = new int[] { 10, 20, 30 };
int[] kisa = { 10, 20, 30 };            // klasik kısa yazım
int[] modern = [10, 20, 30];            // koleksiyon ifadesi (C# 12)

Console.WriteLine(modern[0]);           // 10  — indeks 0'dan başlar
Console.WriteLine(modern.Length);       // 3
modern[1] = 99;                         // eleman değiştirme

// Console.WriteLine(modern[3]);        // IndexOutOfRangeException
