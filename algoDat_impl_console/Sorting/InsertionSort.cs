namespace algoDat_impl_console.Sorting;

public class InsertionSort : ISort
{
    public void Sort(int[] toSort)
    {
        for (int j = 1; j < toSort.Length; j++)
        {
            int currentKey = toSort[j];
            int i = j - 1;
            while (i > -1 && toSort[i] > currentKey)
            {
                toSort[i + 1] = toSort[i];
                i = i - 1;
            }

            toSort[i + 1] = currentKey;
        }
    }
}