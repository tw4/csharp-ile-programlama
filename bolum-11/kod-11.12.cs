// Kod 11.12 — List<T> üzerinde en sık kullanılan işlemler
// Koleksiyon Metotları: Add, Remove, Contains, Sort

List<string> sehirler = ["Ankara", "İzmir", "Bursa"];

sehirler.Add("Antalya");
sehirler.AddRange(["Konya", "Adana"]);
sehirler.Insert(0, "İstanbul");

sehirler.Remove("Bursa");          // değere göre siler
sehirler.RemoveAt(0);              // indekse göre
sehirler.RemoveAll(s => s.StartsWith("A"));

sehirler.Contains("İzmir")         // True
sehirler.IndexOf("Konya")          // indeks veya -1
sehirler.Count                     // eleman sayısı

sehirler.Sort();                            // alfabetik
sehirler.Sort((a, b) => b.CompareTo(a));    // ters
sehirler.Reverse();
sehirler.Clear();
