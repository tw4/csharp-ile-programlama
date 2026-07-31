// Kod 17.1 — Tip güvenli, yeniden kullanılabilir yığın
// Generic Sınıf ve Metotlar

public class Yigin<T>
{
    private readonly List<T> _ogeler = [];

    public int Adet => _ogeler.Count;
    public void Ekle(T oge) => _ogeler.Add(oge);

    public T Cikar()
    {
        if (_ogeler.Count == 0) throw new InvalidOperationException("Yığın boş");
        T son = _ogeler[^1];
        _ogeler.RemoveAt(_ogeler.Count - 1);
        return son;
    }
}
