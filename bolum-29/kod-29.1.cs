// Kod 29.1 — Yalnızca metot değil; özellik ve operatör de eklenebilir
// Uzantı Üyeleri: extension Blokları (C# 14)

public static class NumaralandirmaUzantilari
{
    extension<T>(IEnumerable<T> kaynak)
    {
        public bool BosMu => !kaynak.Any();

        public IEnumerable<T> NullOlmayanlar()
            => kaynak.Where(x => x is not null);
    }
}

int?[] sayilar = [1, null, 3];
Console.WriteLine(sayilar.BosMu);                       // False
Console.WriteLine(sayilar.NullOlmayanlar().Count());    // 2
