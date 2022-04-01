using System.Diagnostics;
using algoDat_impl_library.Extension;

namespace algoDat_impl_library.Searching;

public class BinarySearch : ISearch
{
    public int SearchFor<T>(IList<T> toSearchThrough, T toSearchFor) where T : IComparable<T>
    {
        if (toSearchThrough.Count == 0)
        {
            return -1;
        }

        int foundIndex = 0;

        NextBinaryDive(0, toSearchThrough.Count - 1);
        
        return foundIndex;

        void NextBinaryDive(int startIndex, int endIndex)
        {
            int sequenceLength = endIndex + 1; 
            int offset = (sequenceLength - startIndex) / 2;
            int middle = startIndex + offset;
            Debug.Assert(
                    middle >= 0,
                    "Middle should not get negative, because startIndex can be greater that end-index"
                );
            
            if (toSearchThrough[middle].IsEqual(toSearchFor))
            {
                foundIndex = middle;
            }
            else if (offset == 0)
            {
                foundIndex = -1;
            }
            else if (toSearchFor.IsLessThan(toSearchThrough[middle]))
            {
                NextBinaryDive(startIndex, middle - 1);
            }
            else
            {
                // toSearchFor.IsGreaterThan(toSearchThrough[middle])
                NextBinaryDive(middle + 1, endIndex);
            }
        }
    }
}