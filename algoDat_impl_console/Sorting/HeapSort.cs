using System.Runtime.InteropServices;

namespace algoDat_impl_console.Sorting;

public class HeapSort : ISort
{
    public void Sort<T>(T[] toSort) where T : IComparable<T>
    {
        BuildMaxHeap(toSort);
        for (int downI = toSort.Length; downI > 1;)
        {
            SequenceUtils.Swap(toSort, 0, --downI);
            MaxHeapifyAt(toSort, 0, downI);
        }
    }
    
    private static void MaxHeapifyAt<T>(T[] toHeapify, int index, int heapSize) where T : IComparable<T>
    {

        int factor = index * 2;
        int left = factor + 1;
        int right = factor + 2;

        int largestI = index;

        largestI = left < heapSize && 
                   SortingUtils.IsLessThan(toHeapify[largestI], toHeapify[left] )
            ? left : largestI;
            
        largestI = right < heapSize && 
                   SortingUtils.IsLessThan(toHeapify[largestI], toHeapify[right] )
            ? right : largestI;

        bool wasHeapified = largestI != index;
        if (wasHeapified)
        {
            SequenceUtils.Swap(toHeapify, largestI, index);
            MaxHeapifyAt(toHeapify, largestI, heapSize);
        }
    }


    private static void BuildMaxHeap<T>(T[] toHeapify) where T : IComparable<T>
    {
        for (int i = (toHeapify.Length / 2 ) - 1; i > -1; i--)
        {
            MaxHeapifyAt(toHeapify, i, toHeapify.Length);
        }
    }
}