// Kod 24.6 — Kaçınılması gereken üç kalıp
// Yaygın Hatalar: async void, Deadlock, .Result

// 1) async void: istisna yakalanamaz, çağıran bekleyemez
async void Kaydet() { await DbYazAsync(); }          // YANLIŞ
async Task KaydetAsync() { await DbYazAsync(); }      // DOĞRU

// 2) Senkron bekleme: UI ve ASP.NET'te kilitlenmeye yol açabilir
var veri = VeriAlAsync().Result;                      // YANLIŞ
var veri2 = await VeriAlAsync();                      // DOĞRU

// 3) Gereksiz sarmalama
async Task<int> Getir() => await Task.FromResult(5);  // gereksiz
Task<int> Getir2() => Task.FromResult(5);             // yeterli
