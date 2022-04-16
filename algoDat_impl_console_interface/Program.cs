
using algoDat_impl_library;
using algoDat_impl_library.Benchmark;
using algoDat_impl_library.Sorting;
using algoDat_impl_library.Sorting.SortingWithCounting;

namespace algoDat_impl_console_interface;

public static class Program
{
    private static void Main()
    {
        int[] sequence = new int[]{45, -41, -1, 35, 45646, 56, 999 , 98};
        var oneLength = new int[] { 78, -45, 20, -11 };
        

        
        
        Radix.Sort(sequence);
        Console.WriteLine(SequenceUtils.SequenceToString(sequence));
        Console.WriteLine(SequenceUtils.SequenceToString(oneLength));
    }
}