// Kod 5.1 — Tam sayı bölmesi ve kalan
// Aritmetik ve Atama Operatörleri

int a = 7, b = 2;

Console.WriteLine(a / b);            // 3    <- kesirli kısım ATILIR
Console.WriteLine(a % b);            // 1    <- kalan
Console.WriteLine((double)a / b);    // 3,5  <- doğru sonuç
Console.WriteLine(7.0 / 2);          // 3,5  <- bir taraf ondalıksa yeter

Console.WriteLine(-7 / 2);           // -3   (sıfıra doğru kırpar)
Console.WriteLine(-7 % 2);           // -1
