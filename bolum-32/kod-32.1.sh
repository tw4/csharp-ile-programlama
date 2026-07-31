# Kod 32.1 — Sıfırdan API projesi
# Projeyi Oluşturmak: dotnet new webapi

dotnet new webapi -o GorevApi --use-controllers false
cd GorevApi

dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet run
# https://localhost:7xxx/openapi/v1.json adresinde belge üretilir
