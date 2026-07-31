// Kod 8.5 — Bellek ayırmadan dilim üzerinde çalışmak
// Span<T> ve ReadOnlySpan<T>’e Giriş

ReadOnlySpan<char> metin = "2026-07-26";

int yil = int.Parse(metin[..4]);      // yeni string ÜRETİLMEZ
int ay  = int.Parse(metin[5..7]);
int gun = int.Parse(metin[8..]);

Console.WriteLine(new DateOnly(yil, ay, gun));
