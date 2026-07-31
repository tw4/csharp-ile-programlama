// Kod 22.4 — Yığın izini kaybetmemek
// throw ve throw ex Farkı, Yığın İzinin Korunması

try { IsYap(); }
catch (Exception ex)
{
    Log(ex);
    throw;        // DOĞRU: özgün yığın izi korunur
    // throw ex;  // YANLIŞ: yığın izi buradan yeniden başlar
}
