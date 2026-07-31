// Kod 37.2 — Strategy deseni ile algoritmayı değiştirilebilir kılmak
// Davranışsal Desenler: Strategy, Observer, Mediator

public interface IIndirimStratejisi { decimal Uygula(decimal tutar); }

public sealed class YuzdeIndirim(decimal oran) : IIndirimStratejisi
{
    public decimal Uygula(decimal tutar) => tutar * (1 - oran);
}

public sealed class SabitIndirim(decimal miktar) : IIndirimStratejisi
{
    public decimal Uygula(decimal tutar) => Math.Max(0, tutar - miktar);
}

public sealed class Sepet(IIndirimStratejisi strateji)
{
    public decimal Odenecek(decimal tutar) => strateji.Uygula(tutar);
}
