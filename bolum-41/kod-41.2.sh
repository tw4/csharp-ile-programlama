# Kod 41.2 — Parolaları kaynak koduna yazmamak
# Gizli Bilgilerin Yönetimi (User Secrets, Key Vault)

dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:Blog" "Server=...;Password=..."

// Kodda hiçbir değişiklik gerekmez:
// var cs = builder.Configuration.GetConnectionString("Blog");
