namespace algoDat_impl_console.Sorting;

public class SelectionSort : ISort
{
    public void Sort<T>(IList<T> toSort) where T : IComparable<T>
    {
        int length = toSort.Count - 1;
        
        for (int outerI = 0; outerI < length; outerI++)
        {
            int minI = outerI;
            int innerI = outerI + 1;
            
            for (; innerI < toSort.Count; innerI++)
            {
                minI = Comparing.IsLessThan(toSort[innerI], toSort[minI]) ? innerI : minI;
            }
            
            SequenceUtils.Swap(toSort, minI, outerI);
        }
    }

    
}