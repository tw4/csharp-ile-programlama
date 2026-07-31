// Kod 11.15 — Rastgele değer ve benzersiz kimlik üretimi
// Rastgelelik ve Kimlik: Random, Guid

Random.Shared.Next(1, 7)            // 1-6 arası zar (üst sınır hariç)
Random.Shared.NextDouble()          // 0.0 - 1.0
Random.Shared.Shuffle(dizi);        // diziyi karıştır

Guid.NewGuid()                      // benzersiz kimlik
Guid.CreateVersion7()               // .NET 9+: zamana göre sıralanabilir GUID

// Güvenlik gerektiren yerlerde (token, parola) Random KULLANMAYIN:
string token = Convert.ToHexString(RandomNumberGenerator.GetBytes(32));
