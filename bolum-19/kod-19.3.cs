// Kod 19.3 — Set ve kuyruk davranışı
// HashSet<T>, Queue<T>, Stack<T>, LinkedList<T>

var etiketler = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
{
    "CSharp", "dotnet", "csharp"
};
Console.WriteLine(etiketler.Count); // 2

var kuyruk = new Queue<string>();
kuyruk.Enqueue("siparis-1");
kuyruk.Enqueue("siparis-2");
Console.WriteLine(kuyruk.Dequeue()); // siparis-1
