// Kod 14.6 — Polymorphism ile koşulları sadeleştirmek
// Çok Biçimlilik (Polymorphism) Uygulamaları

public abstract class Bildirim
{
    public abstract Task GonderAsync(string hedef);
}

public sealed class SmsBildirim : Bildirim
{
    public override Task GonderAsync(string hedef)
    {
        Console.WriteLine($"SMS gönderildi: {hedef}");
        return Task.CompletedTask;
    }
}

public sealed class EPostaBildirim : Bildirim
{
    public override Task GonderAsync(string hedef)
    {
        Console.WriteLine($"E-posta gönderildi: {hedef}");
        return Task.CompletedTask;
    }
}

List<Bildirim> bildirimler = [new SmsBildirim(), new EPostaBildirim()];
foreach (var b in bildirimler)
    await b.GonderAsync("mert@ornek.com");
