// Kod 36.1 — İlk birim testi
// Birim Testleri: xUnit ile Başlangıç

using Xunit;

public class HesapMakinesiTestleri
{
    [Fact]
    public void Topla_IkiPozitifSayi_ToplamiDondurur()
    {
        var hesap = new HesapMakinesi();          // Arrange
        int sonuc = hesap.Topla(2, 3);            // Act
        Assert.Equal(5, sonuc);                   // Assert
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Topla_CesitliGirdiler(int a, int b, int beklenen)
        => Assert.Equal(beklenen, new HesapMakinesi().Topla(a, b));
}
