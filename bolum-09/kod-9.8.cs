// Kod 9.8 — İfade gövdeli üyeler
// Yerel Fonksiyonlar ve İfade Gövdeli Üyeler

// Klasik
public string TamAd()
{
    return $"{Ad} {Soyad}";
}

// İfade gövdeli
public string TamAd() => $"{Ad} {Soyad}";

// Özellikler, yapıcılar ve operatörler için de kullanılabilir
public int Yas => DateTime.Today.Year - DogumYili;
public override string ToString() => TamAd();
