using algoDat_impl_library.Extension;

namespace algoDat_impl_library.Sorting;

public class NaturalMergeSort : ISort
{
    public void Sort<T>(IList<T> toSort) where T : IComparable<T>
    {
        var sortedSequences = new Stack<IList<T>>();

        // Getting copying all elements in sorted section.
        // Sorted section can be 1 element too.
        {
            int numberOfFound = 0;
        
            for (int right = 1, left = 0; right < toSort.Count; right++)
            {
                int beforeRight = right - 1;
                    
                if (toSort[beforeRight].IsGreaterThan(toSort[right]))
                {
                    int rightBoundary = right - left;
                    var nextSubSeq = toSort.Splice(left, rightBoundary).ToArray();
                    numberOfFound += nextSubSeq.Length;
                    sortedSequences.Push(nextSubSeq);
                    left = right;
                }
            }
        
            // The last sorted section must be appended too.
            if (numberOfFound < toSort.Count)
            {
                var newSubSeq = toSort.Splice(numberOfFound, toSort.Count).ToArray();
                sortedSequences.Push(newSubSeq);
            }
        }

        // Combine all sorted section
        {
            

            if (sortedSequences.Count < 2)
            {
                // Sequence is already sorted.
                return;
            }

            IList<T> previousSortedSection = sortedSequences.Pop();
        
            bool moreThan2Left = sortedSequences.Count > 1;
            while (moreThan2Left)
            {
                IList<T> currentSortedSection = sortedSequences.Pop();
                previousSortedSection = MergeSort.CombineSorted(previousSortedSection, currentSortedSection);
                moreThan2Left = sortedSequences.Count > 1;
            }
        
             
            MergeSort.CombineSortedInto(previousSortedSection, sortedSequences.Pop(), toSort);
        }

    }
}