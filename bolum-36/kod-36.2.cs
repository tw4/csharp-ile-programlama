// Kod 36.2 — Bağımlılıkları taklit etmek
// Sahte Nesneler (Mock) ve NSubstitute/Moq

var depo = Substitute.For<ISiparisDeposu>();
depo.GetirAsync(1, Arg.Any<CancellationToken>())
    .Returns(new Siparis { Id = 1, Tutar = 100m });

var servis = new SiparisServisi(depo);
var sonuc = await servis.OzetAsync(1);

Assert.Equal(100m, sonuc.Tutar);
await depo.Received(1).GetirAsync(1, Arg.Any<CancellationToken>());
