# Kod 32.11 — Derleme zamanında JSON belgesi üretmek
# Yerleşik OpenAPI 3.1 ve Belge Üretimi

dotnet add package Microsoft.Extensions.ApiDescription.Server

<PropertyGroup>
  <OpenApiGenerateDocuments>true</OpenApiGenerateDocuments>
  <OpenApiDocumentsDirectory>./belgeler</OpenApiDocumentsDirectory>
</PropertyGroup>
