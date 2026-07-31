// Kod 4.2 — double ile decimal arasındaki fark
// Tam Sayılar, Ondalıklı Sayılar ve decimal

double a = 0.1, b = 0.2;
Console.WriteLine(a + b);            // 0,30000000000000004
Console.WriteLine(a + b == 0.3);     // False (!)

decimal c = 0.1m, d = 0.2m;
Console.WriteLine(c + d);            // 0,3
Console.WriteLine(c + d == 0.3m);    // True
