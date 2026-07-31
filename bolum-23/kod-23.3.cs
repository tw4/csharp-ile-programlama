// Kod 23.3 — Derleyiciye ek bilgi vermek
// Nullable Öznitelikleri: NotNull, MaybeNull, MemberNotNull

using System.Diagnostics.CodeAnalysis;

public sealed class Onbellek
{
    private Dictionary<string, string>? _veri;

    [MemberNotNull(nameof(_veri))]
    private void Hazirla() => _veri ??= [];

    public bool Dene(string anahtar, [NotNullWhen(true)] out string? deger)
    {
        Hazirla();                       // sonrasında _veri null değil
        return _veri.TryGetValue(anahtar, out deger);
    }
}
