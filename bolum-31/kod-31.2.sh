# Kod 31.2 — Şema değişikliklerini kod üzerinden yönetmek
# Code First ve Migrations

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef migrations add IlkOlusturma
dotnet ef database update
dotnet ef migrations script -o sema.sql
