// Kod 33.5 — Sürümü rotaya taşımak
// API Sürümleme Stratejileri

var v1 = app.MapGroup("/api/v1");
var v2 = app.MapGroup("/api/v2");

v1.MapGet("/gorevler", ListeleV1Async);
v2.MapGet("/gorevler", ListeleV2Async);    // yeni alanlar, kırıcı değişiklikler

// Alternatifler: Accept başlığı (media type versioning),
// ?api-version=2 sorgu parametresi veya X-Api-Version başlığı.
