// Kod 26.1 — Platformdan bağımsız yol ve dosya işlemleri
// File, Directory ve Path Sınıfları

string klasor = Path.Combine(AppContext.BaseDirectory, "veri");
Directory.CreateDirectory(klasor);       // varsa hata vermez

string yol = Path.Combine(klasor, "ayarlar.json");
File.WriteAllText(yol, "{ \"tema\": \"koyu\" }");

Console.WriteLine(Path.GetFileName(yol));     // ayarlar.json
Console.WriteLine(File.Exists(yol));          // True
