using algoDat_impl_console.Sorting;

namespace algoDat_impl_console;

class Program
{
    static void Main()
    {
        ISort sorter = new InsertionSort();
        sorter.Sort(new int[]{4, 2, 3, 1});
    }
}
