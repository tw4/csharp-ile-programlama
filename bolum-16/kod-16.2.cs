// Kod 16.2 — readonly struct ve ref struct kullanım farkı
// readonly struct ve ref struct

public readonly struct Para
{
    public decimal Tutar { get; }
    public string Birim { get; }
    public Para(decimal tutar, string birim) => (Tutar, Birim) = (tutar, birim);
}

public ref struct ArabellekDilimi
{
    private Span<byte> _span;
    public ArabellekDilimi(Span<byte> span) => _span = span;
    public void Temizle() => _span.Clear();
}
