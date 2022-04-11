
using algoDat_impl_library;
using algoDat_impl_library.Benchmark;
using algoDat_impl_library.Sorting;

namespace algoDat_impl_console_interface;

public static class Program
{
    private static void Main()
    {
        var array = new int[] { 2, 4 };
        Console.WriteLine($"array.IsFixedSize: {array.IsFixedSize}");
        Console.WriteLine($"array.IsReadOnly: {array.IsReadOnly}");
    }
}