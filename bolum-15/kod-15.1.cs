// Kod 15.1 — Sözleşme tanımlamak ve uygulamak
// Arayüz Tanımı ve Uygulaması

public interface IBildirimGonderici
{
    string Kanal { get; }
    Task GonderAsync(string alici, string mesaj, CancellationToken ct = default);
}

public sealed class EpostaGonderici : IBildirimGonderici
{
    public string Kanal => "E-posta";

    public Task GonderAsync(string alici, string mesaj, CancellationToken ct = default)
    {
        Console.WriteLine($"[{Kanal}] {alici} -> {mesaj}");
        return Task.CompletedTask;
    }
}
