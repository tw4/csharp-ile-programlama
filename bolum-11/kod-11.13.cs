// Kod 11.13 — Pratikte işlerin %90’ını gören 15 operatör
// LINQ’in En Sık Kullanılan Operatörleri

int[] s = [5, 3, 9, 1, 7, 3];

s.Where(x => x > 3)          // filtrele          -> 5, 9, 7
s.Select(x => x * 2)         // dönüştür          -> 10, 6, 18, ...
s.OrderBy(x => x)            // sırala            -> 1, 3, 3, 5, 7, 9
s.OrderByDescending(x => x)  // tersten sırala
s.First();  s.FirstOrDefault(x => x > 100)   // ilk / yoksa varsayılan
s.Last();   s.Single(x => x == 9)            // son / tam bir tane
s.Any(x => x > 8)            // en az biri?      -> True
s.All(x => x > 0)            // hepsi mi?        -> True
s.Count(x => x == 3)         // koşullu sayım    -> 2
s.Sum();  s.Average();  s.Min();  s.Max()
s.Distinct()                 // yinelenenleri at
s.Take(3);  s.Skip(2)        // sayfalama ikilisi
s.Contains(7)                // içeriyor mu?
s.ToList();  s.ToArray();  s.ToDictionary(x => x)
