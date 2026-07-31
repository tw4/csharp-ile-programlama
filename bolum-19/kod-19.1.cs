// Kod 19.1 — List kapasitesi ve büyüme maliyeti
// List<T> ve İç Yapısı

var liste = new List<int>(capacity: 4);
for (int i = 1; i <= 8; i++)
{
    liste.Add(i);
    Console.WriteLine($"Adet={liste.Count}, Kapasite={liste.Capacity}");
}
