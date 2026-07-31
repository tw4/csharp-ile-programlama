// Kod 23.1 — Derleyicinin null analizinden yararlanmak
// Nullable Referans Tipleri (NRT) ve Derleyici Uyarıları

#nullable enable

public string Bicimle(string? girdi)
{
    // Console.WriteLine(girdi.Length);   // CS8602 uyarısı: olası null

    if (girdi is null) return "(boş)";
    return girdi.Trim();                  // burada artık null olamaz
}
