using System.Diagnostics;
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
            // pivot element is always at the end.
            if (end <= start) return;

            var higherBound = start;
            var lowerBound = start - 1;

            Debug.Assert(higherBound > -1, "Arranging goes outside array to the left.");

            for (; higherBound < end; higherBound++)
            {
                if (toSort[higherBound].IsLessThan(toSort[end]))
                {
                    lowerBound++;
                    SequenceUtils.Swap(toSort, lowerBound, higherBound);
                }

                Debug.Assert(
                    lowerBound <= higherBound,
                    "Bound for smaller elements must not get past higherBound for greater elements than the pivot element"
                    );
            }

            // Pivot element at the end index is inserted at certain index. 
            // After the insertion the all elements before the pivot element are smaller.
            // Those elements are the left part from the pivot element.
            // After the insertion the all elements after the pivot element are bigger.
            // Those elements are the right part from the pivot element.
            lowerBound++;
            Debug.Assert(lowerBound <= end, "Arranging is leaving the array to the right");
            SequenceUtils.Swap(toSort, lowerBound, end);

            // Arrange elements from the left of the pivot element 
            ArrangeAllBeforeEnd(start, lowerBound - 1);
            // Arrange elements from the right of the pivot element
            ArrangeAllBeforeEnd(lowerBound + 1, end);
        }
    }
}