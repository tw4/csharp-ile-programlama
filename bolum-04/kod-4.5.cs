// Kod 4.5 — const ve readonly karşılaştırması
// Sabitler: const ve readonly

public class Cember
{
    public const double Pi = 3.14159;          // derleme anında sabit
    public static readonly DateTime Baslangic = DateTime.Now;  // çalışma anında belirlenir

    public readonly int YaricapCm;

    public Cember(int yaricap) => YaricapCm = yaricap;  // yalnızca burada atanabilir
}
