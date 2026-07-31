// Kod 25.4 — Sınırlı kapasiteli iş kuyruğu
// Kanallar (Channels) ile Üretici-Tüketici Deseni

using System.Threading.Channels;

var kanal = Channel.CreateBounded<string>(new BoundedChannelOptions(100)
{
    FullMode = BoundedChannelFullMode.Wait
});

// Üretici
_ = Task.Run(async () =>
{
    foreach (var is_ in isler) await kanal.Writer.WriteAsync(is_);
    kanal.Writer.Complete();
});

// Tüketici
await foreach (string is_ in kanal.Reader.ReadAllAsync())
    await IsleAsync(is_);
