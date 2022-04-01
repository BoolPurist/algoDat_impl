namespace algoDat_impl_console.Sorting;

public class InsertionSort : ISort
{
    public void Sort<T>(T[] toSort) where T : IComparable<T>
    {
        for (int j = 1; j < toSort.Length; j++)
        {
            T currentKey = toSort[j];
            int i = j - 1;
            while (i > -1 && SortingUtils.IsGreaterThan(toSort[i], currentKey))
            {
                toSort[i + 1] = toSort[i];
                i = i - 1;
            }

            toSort[i + 1] = currentKey;
        }
    }
}