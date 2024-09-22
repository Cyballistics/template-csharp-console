using BenchmarkDotNet.Attributes;
using MyApp;  // Reference your main project here

[MemoryDiagnoser]
public class MyAppBenchmarks
{

    /// <summary>
    /// MyAppBenchmark constructor
    /// </summary>
    public MyAppBenchmarks()
    {
    }

    /// <summary>
    /// MyApp method to benchmark
    /// </summary>
    [Benchmark]
    public void BenchmarkMethod1()
    {
    }

    /// <summary>
    /// MyApp method to benchmark
    /// </summary>
    [Benchmark]
    public void BenchmarkMethod2()
    {
    }
}