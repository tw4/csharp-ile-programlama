# Kod 2.4 — Projeyi oluşturma, çalıştırma ve paket ekleme
# İlk Proje: dotnet new console

dotnet new console -o MerhabaDunya
cd MerhabaDunya
dotnet run

dotnet add package Humanizer
dotnet build -c Release
