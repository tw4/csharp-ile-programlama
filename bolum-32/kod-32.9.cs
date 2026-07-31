// Kod 32.9 — İstek hattına kendi halkanızı eklemek
// Ara Yazılım (Middleware) Zinciri

app.Use(async (context, next) =>
{
    var sure = System.Diagnostics.Stopwatch.StartNew();
    await next(context);
    sure.Stop();

    context.Response.Headers["X-Sure-ms"] = sure.ElapsedMilliseconds.ToString();
});

app.UseAuthentication();
app.UseAuthorization();
