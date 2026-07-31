// Kod 41.4 — Uygulamayı gözlemlenebilir hâle getirmek
// Uygulama İzleme, Metrik ve Dağıtık İzleme (OpenTelemetry)

builder.Services.AddOpenTelemetry()
    .ConfigureResource(r => r.AddService("BlogApi"))
    .WithTracing(t => t
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddOtlpExporter())
    .WithMetrics(m => m
        .AddAspNetCoreInstrumentation()
        .AddRuntimeInstrumentation()
        .AddOtlpExporter());
