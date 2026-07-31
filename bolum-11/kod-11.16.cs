// Kod 11.16 — Tek satırlık dosya işlemleri
// Dosya ve Yol Kısa Yolları: File, Path, Directory

File.Exists("veri.txt")
File.ReadAllText("veri.txt");        File.ReadAllLines("veri.txt")
File.WriteAllText("veri.txt", icerik);   File.AppendAllText("log.txt", satir)
File.Copy("a.txt", "b.txt", overwrite: true);  File.Delete("b.txt")

Path.Combine("klasor", "alt", "dosya.txt")   // platforma uygun ayraç
Path.GetFileName("/tmp/rapor.pdf")           // rapor.pdf
Path.GetFileNameWithoutExtension(yol)        // rapor
Path.GetExtension(yol)                       // .pdf
Path.GetDirectoryName(yol)

Directory.CreateDirectory("cikti");
Directory.GetFiles("cikti", "*.json", SearchOption.AllDirectories);
