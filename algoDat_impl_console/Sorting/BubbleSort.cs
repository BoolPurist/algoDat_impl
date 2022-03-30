namespace algoDat_impl_console.Sorting;

public class BubbleSort : ISort
{
    public void Sort(int[] toSort)
    {
        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            
            int length = toSort.Length - 1;
            for (int i = 0; i < length; i++)
            {
                int nextIndex = i + 1;
                if (toSort[i] > toSort[nextIndex])
                {
                    SequenceUtils.Swap(toSort, i, nextIndex);
                    isSorted = false;
                }
            }
        }
    }
}