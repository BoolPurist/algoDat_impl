namespace algoDat_impl_console.Sorting;

public class SelectionSort : ISort
{
    public void Sort(int[] toSort)
    {
        int length = toSort.Length - 1;
        for (int outer_i = 0; outer_i < length; outer_i++)
        {
            int min_i = outer_i;
            int inner_i = outer_i + 1;
            for (; inner_i < toSort.Length; inner_i++)
            {
                if (toSort[inner_i] < toSort[min_i])
                {
                    min_i = inner_i;
                }
            }
            
            SequenceUtils.Swap(toSort, min_i, outer_i);
        }
    }
}