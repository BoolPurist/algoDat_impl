using System.Diagnostics;

namespace algoDat_impl_library.Sorting.SortingWithCounting;

public class CountSort
{
    private int _max = 1;
    
    public CountSort(int max)
    {
        _max = max;
    }
    
    public void Sort(IList<int> toSort)
    {
        var counting = new int[toSort.Count + 1];
        counting[0] = -1;
        
        foreach (int index in toSort)
        {
            counting[index]++;
        }

        AddCountingUp(counting);

        int[] result = new int[toSort.Count];
        for (int i = result.Length - 1; i != -1; i--)
        {
            int toInsert = toSort[i];
            int insertIndex = counting[toSort[i]];
            result[insertIndex] = toInsert;
            counting[toSort[i]]--;
        }

        for (int i = 0; i < result.Length; i++)
        {
            toSort[i] = result[i];
        }
    }

    public static void AddCountingUp(IList<int> counting)
    {
        for (int i = 1; i < counting.Count; i++)
        {
            counting[i] = counting[i - 1] + counting[i];
            Debug.Assert(counting[i] >= counting[i - 1]);
        }
    }
}