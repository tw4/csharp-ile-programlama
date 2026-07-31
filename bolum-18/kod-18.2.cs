// Kod 18.2 — LSP ihlali örneği
// Liskov Yerine Geçme İlkesi

public class Kus
{
    public virtual void Uc() => Console.WriteLine("Kuş uçuyor.");
}

public class Penguen : Kus
{
    public override void Uc() => throw new NotSupportedException();
}
