// Kod 3.3 — Proje dosyası olmadan çalışan tek dosyalık uygulama (.NET 10)
// Tek Dosyalık Uygulamalar: dotnet run app.cs

#!/usr/bin/env dotnet run
#:package Humanizer@2.14.1

using Humanizer;

var gun = 3;
Console.WriteLine($"{gun} gün önce = {DateTime.Now.AddDays(-gun).Humanize()}");

// Çalıştırma:  dotnet run app.cs
// Projeye dönüştürme:  dotnet project convert app.cs
