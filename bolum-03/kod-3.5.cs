// Kod 3.5 — Kullanıcıdan veri alan basit bir etkileşim
// Konsola Yazma ve Konsoldan Okuma

Console.Write("Adınız: ");
string? ad = Console.ReadLine();

Console.Write("Doğum yılınız: ");
if (int.TryParse(Console.ReadLine(), out int yil))
{
    int yas = DateTime.Now.Year - yil;
    Console.WriteLine($"Merhaba {ad}, bu yıl {yas} yaşına giriyorsunuz.");
}
else
{
    Console.WriteLine("Geçerli bir yıl girmediniz.");
}
