// Kod 30.2 — Servisleri kaydetmek ve çözümlemek
// Microsoft.Extensions.DependencyInjection

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<IZamanSaglayici, SistemZamani>();
builder.Services.AddScoped<ISiparisDeposu, SqlSiparisDeposu>();
builder.Services.AddTransient<IBildirimGonderici, EpostaGonderici>();
builder.Services.AddHostedService<GunlukRaporServisi>();

using IHost host = builder.Build();
await host.RunAsync();
