using algoDat_impl_library.Extension;

namespace algoDat_impl_library.Sorting;

public class InsertionSort : ISort
{
    public void Sort<T>(IList<T> toSort) where T : IComparable<T>
    {
        for (int outerI = 1; outerI < toSort.Count; outerI++)
        {
            T currentKey = toSort[outerI];
            int innerI = outerI - 1;
            while (innerI > -1 && toSort[innerI].IsGreaterThan(currentKey))
            {
                int whereToMove = innerI + 1;
                toSort[whereToMove] = toSort[innerI];
                innerI--;
            }

            toSort[innerI + 1] = currentKey;
        }
    }
}