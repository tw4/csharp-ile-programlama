// Kod 33.1 — .NET 10 ile Minimal API'de yerleşik doğrulama
// Model Doğrulama ve Veri Ek Açıklamaları

using System.ComponentModel.DataAnnotations;

builder.Services.AddValidation();      // .NET 10

public record YaziOlusturDto(
    [Required, StringLength(200)] string Baslik,
    [Required, MinLength(10)]     string Icerik);

app.MapPost("/yazilar", (YaziOlusturDto dto) => Results.Ok(dto));
// Geçersiz gövde -> otomatik 400 + ValidationProblemDetails
