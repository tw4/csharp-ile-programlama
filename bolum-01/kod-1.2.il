// Kod 1.2 — Aynı metodun ürettiği IL kodu (ildasm/ILSpy çıktısı)
// Yönetilen Kod, IL ve JIT Derleme

.method private hidebysig static int32 Topla(int32 a, int32 b) cil managed
{
  .maxstack 2
  ldarg.0        // a'yı yığına yükle
  ldarg.1        // b'yi yığına yükle
  add            // topla
  ret            // sonucu döndür
}
