// Kod 27.3 — Tahmin etmeyin, ölçün
// BenchmarkDotNet ile Ölçüm

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class MetinTestleri
{
    private readonly string[] _parcalar = Enumerable.Range(0, 1000)
                                                    .Select(i => i.ToString())
                                                    .ToArray();

    [Benchmark(Baseline = true)]
    public string Concat() => _parcalar.Aggregate("", (a, b) => a + b);

    [Benchmark]
    public string Join() => string.Join("", _parcalar);
}

BenchmarkRunner.Run<MetinTestleri>();
