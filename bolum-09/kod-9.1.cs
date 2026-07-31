// Kod 9.1 — Metot tanımının parçaları
// Metot Tanımı, Parametre ve Dönüş Değeri

//  ↓ erişim   ↓ dönüş tipi
    public      decimal   VergiHesapla(decimal tutar, decimal oran)
//                        ↑ ad         ↑ parametre listesi
{
    return tutar * oran;               // dönüş değeri
}

public void Uyar(string mesaj)         // değer döndürmez
{
    Console.WriteLine($"[UYARI] {mesaj}");
    // return;   -> isteğe bağlı, erken çıkmak için kullanılır
}

// Çağırma
decimal kdv = VergiHesapla(1000m, 0.20m);   // 200
Uyar("Stok azaldı");
