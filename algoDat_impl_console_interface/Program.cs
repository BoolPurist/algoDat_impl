
using algoDat_impl_library;
using algoDat_impl_library.Benchmark;
using algoDat_impl_library.Sorting;
using algoDat_impl_library.Sorting.SortingWithCounting;

namespace algoDat_impl_console_interface;

public static class Program
{
    private static void Main()
    {
        var testInput = new int[] {1, 2, 3, 1, 5};
        new CountSort(5).Sort(testInput);
    }
}