
using algoDat_impl_library;
using algoDat_impl_library.Sorting;

namespace algoDat_impl_console_interface;

public static class Program
{
    private static void Main()
    {
        var sequence = new int[] {2, 4, 1, 3, 5, 1, 5};
        new NaturalMergeSort().Sort( sequence );
        Console.WriteLine(SequenceUtils.SequenceToString(sequence));
    }
}