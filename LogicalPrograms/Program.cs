using LogicalPrograms_;

internal class Program
{
    private static void Main(string[] args)
    {
        FibonacciSeries fibonacciSeries = new FibonacciSeries();
        fibonacciSeries.Main(args);

        PerfectNumber perfectNumber = new PerfectNumber();
        perfectNumber.CheckPerfactNum();
    }
}