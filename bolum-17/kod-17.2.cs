// Kod 17.2 — Kısıtlamalarla derleyiciye bilgi vermek
// Tip Kısıtlamaları (where)

public static T EnBuyuk<T>(IEnumerable<T> ogeler)
    where T : IComparable<T>
{
    using var e = ogeler.GetEnumerator();
    if (!e.MoveNext()) throw new ArgumentException("Koleksiyon boş", nameof(ogeler));

    T enBuyuk = e.Current;
    while (e.MoveNext())
        if (e.Current.CompareTo(enBuyuk) > 0) enBuyuk = e.Current;

    return enBuyuk;
}

// where T : class, struct, new(), notnull, unmanaged ... da kullanılabilir
