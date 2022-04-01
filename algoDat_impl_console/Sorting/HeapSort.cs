using System.Runtime.InteropServices;

namespace algoDat_impl_console.Sorting;

public class HeapSort : ISort
{
    public void Sort(int[] toSort)
    {
        BuildMaxHeap(toSort);
        for (int downI = toSort.Length; downI > 1;)
        {
            SequenceUtils.Swap(toSort, 0, --downI);
            MaxHeapifyAt(toSort, 0, downI);
        }
    }
    
    private static void MaxHeapifyAt(int[] toHeapify, int index, int heapSize)
    {

        int factor = index * 2;
        int left = factor + 1;
        int right = factor + 2;

        int largestI = index;

        largestI = left < heapSize && 
                   toHeapify[largestI] < toHeapify[left] 
            ? left : largestI;
            
        largestI = right < heapSize && 
                   toHeapify[largestI] < toHeapify[right] 
            ? right : largestI;

        bool wasHeapified = largestI != index;
        if (wasHeapified)
        {
            SequenceUtils.Swap(toHeapify, largestI, index);
            MaxHeapifyAt(toHeapify, largestI, heapSize);
        }
    }


    private static void BuildMaxHeap(int[] toHeapify)
    {
        for (int i = (toHeapify.Length / 2 ) - 1; i > -1; i--)
        {
            MaxHeapifyAt(toHeapify, i, toHeapify.Length);
        }
    }
}