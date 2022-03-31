using algoDat_impl_console.Sorting;

namespace algoDat_impl_console;

class Program
{
    static void Main()
    {
        var toSort = new int[] { 2, 5, -8, -2 };
        
        new MergeSort().Sort(toSort);
        foreach (var number in toSort)
        {
            Console.Write($"{number} ");
        }
        
        Console.WriteLine();
    }
}
