# Kod 2 — Günlük geliştirme komutları
# Derleme, Çalıştırma ve Test Komutları

dotnet restore
dotnet build -c Release
dotnet run --project Uygulama
dotnet watch run                     # değişiklikte otomatik yeniden başlat
dotnet test --logger "console;verbosity=detailed"
dotnet format
