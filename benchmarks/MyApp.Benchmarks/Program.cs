using BenchmarkDotNet.Running;


namespace MyApp.Benchmarks
{

    class Program
    {
        static void Main(string[] args)
        {
            // Run benchmarks
            var _ = BenchmarkRunner.Run<MyAppBenchmarks>();
        }
    }

}