
using algoDat_impl_library;
using algoDat_impl_library.Benchmark;
using algoDat_impl_library.Sorting;

namespace algoDat_impl_console_interface;

public static class Program
{
    private static void Main()
    {
        var sequence = new RandomIntArrayGenerator(-1000, 1000, 100).Generate();
        Console.WriteLine(SequenceUtils.SequenceToString(sequence));
    }
}