using System.Diagnostics;
using System.Reflection.PortableExecutable;
using algoDat_impl_library.Extension;

namespace algoDat_impl_library.Sorting;

public class QuickSort : ISort
{
    
    public void Sort<T>(IList<T> toSort) where T : IComparable<T>
    {
        // This function uses the last element of a range as the pivot element.
        // This function sorts the array in place.
        ArrangeAllBeforeEnd(0, toSort.Count - 1);

        // Arranges the array in way so the element at the index (end)
        // is placed in a spot so that all other elements before are smaller
        // and all other elements after are bigger
        void ArrangeAllBeforeEnd(int start, int end)
        {
            if (end <= start)
            {
                return;
            }

            int higherBound = start;
            int lowerBound = start - 1; 
            
            for (; higherBound < end; higherBound++ ) 
            {
                if (toSort[higherBound].IsLessThan(toSort[end]))
                {
                    lowerBound++;
                    SequenceUtils.Swap(toSort, lowerBound, higherBound);
                }
            }
            
            // Pivot element at the end index is inserted at certain index. 
            // After the insertion the all elements before the pivot element are smaller.
            // Those elements are the left part from the pivot element.
            // After the insertion the all elements after the pivot element are bigger.
            // Those elements are the right part from the pivot element.
            lowerBound++;
            SequenceUtils.Swap(toSort, lowerBound, end);
            
            // Arrange elements from the left of the pivot element 
            ArrangeAllBeforeEnd(start, lowerBound - 1);
            // Arrange elements from the right of the pivot element
            ArrangeAllBeforeEnd(lowerBound + 1, end);
        }
    }
}