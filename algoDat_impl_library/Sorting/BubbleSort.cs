using algoDat_impl_library.Extension;

namespace algoDat_impl_library.Sorting;

public class BubbleSort : ISort
{
    public void Sort<T>(IList<T> toSort) where T : IComparable<T>
    {
        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            
            int length = toSort.Count - 1;
            for (int i = 0; i < length; i++)
            {
                int nextIndex = i + 1;
                
                if ( toSort[i].IsGreaterThan(toSort[nextIndex]) )
                {
                    SequenceUtils.Swap(toSort, i, nextIndex);
                    isSorted = false;
                }
            }
        }
    }
}