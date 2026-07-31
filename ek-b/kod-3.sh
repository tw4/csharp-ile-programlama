# Kod 3 — NuGet ve global araçlar
# Paket ve Araç Komutları

dotnet add package Serilog.AspNetCore
dotnet list package --outdated
dotnet list package --vulnerable
dotnet tool install --global dotnet-ef
dotnet pack -c Release
dotnet nuget push bin/Release/*.nupkg -s nuget.org -k $API_KEY
