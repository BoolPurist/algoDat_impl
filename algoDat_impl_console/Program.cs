using algoDat_impl_console.Sorting;

namespace algoDat_impl_console;

class Program
{
    static void Main()
    {
        var array = new int[] {1, 2, 3};

        SequenceUtils.InPlaceReverse(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}");
        }
    }
}
