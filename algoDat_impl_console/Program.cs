using algoDat_impl_console.Sorting;
using algoDat_impl_console.Benmark;

namespace algoDat_impl_console;

class Program
{
    static void Main()
    {
        var input = new[] { 81, 89, 9, 11, 14, 76, 54, 22 };

        new HeapSort().Sort(input);
        Console.WriteLine(SequenceUtils.PrintSequence(input));

    }
}
