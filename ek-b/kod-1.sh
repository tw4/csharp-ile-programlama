# Kod 1 — En sık kullanılan proje komutları
# Proje ve Çözüm Komutları

dotnet new list                      # şablonları listele
dotnet new console -o Uygulama
dotnet new classlib -o Kutuphane
dotnet new sln -n Cozum
dotnet sln add Uygulama/Uygulama.csproj
dotnet add Uygulama reference Kutuphane
