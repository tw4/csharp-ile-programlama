// Kod 7.2 — for döngüsünün esnek kullanımları
// for Döngüsü

// Geriye doğru
for (int i = 10; i > 0; i--) Console.Write($"{i} ");

// İkişer artarak
for (int i = 0; i <= 100; i += 2) { }

// Birden fazla değişken
for (int i = 0, j = 10; i < j; i++, j--) { }

// Sonsuz döngü (içeriden break ile çıkılır)
for (;;) { break; }
