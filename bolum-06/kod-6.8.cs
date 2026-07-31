// Kod 6.8 — İç içe yapıyı erken çıkışla düzleştirmek
// Kaçınılması Gereken Karmaşık Koşullar

// ÖNCE — piramit
void Isle(Siparis? s)
{
    if (s is not null)
        if (s.Onayli)
            if (s.Tutar > 0)
                Kaydet(s);
}

// SONRA — düz
void Isle(Siparis? s)
{
    if (s is null) return;
    if (!s.Onayli) return;
    if (s.Tutar <= 0) return;

    Kaydet(s);
}
