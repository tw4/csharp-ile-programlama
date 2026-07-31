# Kod 40.1 — Yayın için derleme çeşitleri
# dotnet publish Seçenekleri

# Çerçeveye bağımlı
dotnet publish -c Release -o ./yayin

# Kendi kendine yeten, tek dosya
dotnet publish -c Release -r win-x64 --self-contained true \
  -p:PublishSingleFile=true -p:EnableCompressionInSingleFile=true

# Native AOT
dotnet publish -c Release -r linux-x64 -p:PublishAot=true
