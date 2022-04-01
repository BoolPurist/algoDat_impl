namespace algoDat_impl_console.Sorting;

public class SelectionSort : ISort
{
    public void Sort(int[] toSort)
    {
        int length = toSort.Length - 1;
        
        for (int outerI = 0; outerI < length; outerI++)
        {
            int minI = outerI;
            int innerI = outerI + 1;
            
            for (; innerI < toSort.Length; innerI++)
            {
                minI = toSort[innerI] < toSort[minI] ? innerI : minI;
            }
            
            SequenceUtils.Swap(toSort, minI, outerI);
        }
    }
}