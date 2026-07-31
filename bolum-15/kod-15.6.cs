// Kod 15.6 — IDisposable ile kaynak yönetimi
// Sık Kullanılan BCL Arayüzleri: IComparable, IEquatable, IDisposable

public sealed class LogYazici : IDisposable
{
    private readonly StreamWriter _writer;

    public LogYazici(string yol) => _writer = File.AppendText(yol);

    public void Yaz(string metin) =>
        _writer.WriteLine($"[{DateTime.UtcNow:O}] {metin}");

    public void Dispose() => _writer.Dispose();
}

using (var log = new LogYazici("uygulama.log"))
{
    log.Yaz("Uygulama başladı.");
} // using bloğu bitince Dispose çağrılır
