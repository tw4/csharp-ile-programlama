// Kod 33.3 — JWT tabanlı koruma
// Kimlik Doğrulama ve Yetkilendirme (JWT)

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(o =>
    {
        o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(anahtar)
        };
    });

builder.Services.AddAuthorization();

app.MapGet("/gizli", () => "Yalnızca giriş yapanlar görür")
   .RequireAuthorization();
