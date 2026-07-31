// Kod 33.2 — Standart hata gövdesi üretmek
// Hata Yönetimi, ProblemDetails ve Global İstisna İşleyici

builder.Services.AddProblemDetails(o =>
    o.CustomizeProblemDetails = ctx =>
        ctx.ProblemDetails.Extensions["izlemeId"] = ctx.HttpContext.TraceIdentifier);

app.UseExceptionHandler();
app.UseStatusCodePages();

// Elle üretim
return Results.Problem(
    title: "Sipariş bulunamadı",
    statusCode: StatusCodes.Status404NotFound);
