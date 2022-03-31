using algoDat_impl_console.Sorting;
using algoDat_impl_console.Benmark;

namespace algoDat_impl_console;

class Program
{
    static void Main()
    {
        var toSort = new RandomIntArrayGenerator(0, 10, int.MaxValue / 10).Generate();
        string passed = Benchmark.GetMeasureTimeStampFrom(
            () =>
        {
            new MergeSort().Sort(toSort);

            Console.WriteLine();
        });
        
        Console.WriteLine(passed);
    }
}
