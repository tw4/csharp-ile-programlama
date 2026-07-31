// Kod 32.10 — .NET 10'da Swashbuckle olmadan OpenAPI
// Yerleşik OpenAPI 3.1 ve Belge Üretimi

builder.Services.AddOpenApi(o =>
{
    o.AddDocumentTransformer((doc, ctx, ct) =>
    {
        doc.Info.Title   = "Görev API";
        doc.Info.Version = "v1";
        return Task.CompletedTask;
    });
});

app.MapOpenApi();                     // /openapi/v1.json

app.MapGet("/gorevler", ListeleAsync)
   .WithSummary("Tüm görevleri listeler")
   .Produces<List<GorevDto>>(StatusCodes.Status200OK);
