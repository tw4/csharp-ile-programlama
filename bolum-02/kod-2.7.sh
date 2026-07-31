# Kod 2.7 — Paket ekleme, listeleme ve kaldırma
# NuGet Paket Yönetimi Temelleri

dotnet add package Serilog.AspNetCore          # en güncel sürümü ekler
dotnet add package Newtonsoft.Json --version 13.0.3

dotnet list package                            # projedeki paketler
dotnet list package --outdated                 # güncelleme bekleyenler
dotnet list package --vulnerable               # güvenlik açığı bilinenler

dotnet remove package Newtonsoft.Json
