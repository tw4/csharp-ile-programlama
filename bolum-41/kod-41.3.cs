// Kod 41.3 — Parolayı tuzlanmış özet ile saklamak
// Parola Saklama ve Kriptografi Temelleri

using System.Security.Cryptography;

static (byte[] ozet, byte[] tuz) ParolaOzetle(string parola)
{
    byte[] tuz = RandomNumberGenerator.GetBytes(16);
    byte[] ozet = Rfc2898DeriveBytes.Pbkdf2(
        parola, tuz, iterations: 210_000, HashAlgorithmName.SHA256, 32);

    return (ozet, tuz);
}

// Parolayı ASLA düz metin veya MD5/SHA1 ile saklamayın.
