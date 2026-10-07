// Kod 16.1 — struct için uygun bir değer nesnesi
// struct Ne Zaman Tercih Edilir

public readonly struct Koordinat
{
    public double Enlem { get; }
    public double Boylam { get; }

    public Koordinat(double enlem, double boylam)
    {
        Enlem = enlem;
        Boylam = boylam;
    }

    // Derece cinsinden kaba yaklaşım (gerçek km: Haversine)
    public double KusBakisiMesafe(Koordinat diger)
    {
        double dEnlem = Enlem - diger.Enlem;
        double dBoylam = Boylam - diger.Boylam;
        return Math.Sqrt(dEnlem * dEnlem + dBoylam * dBoylam);
    }
}
