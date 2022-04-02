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
                
                int nextLeft = middle - 1;
                
                // Covering the case of the found value being a duplicate in the sequence
                // Ensures requirement of returning the index for the first value 
                // equal to the value of toSearchFor
                // Worst case is increased by (n / 2) for comparisons.
                while (nextLeft > -1)
                {
                    if (toSearchThrough[nextLeft].IsLessThan(toSearchFor))
                    {
                        break;
                    }
                    nextLeft--;
                }

                // nextLeft can be -1 or the index just before the 1. found value equal 
                // to toSearchFo. -1 means that the 0. element in the sequence is
                // equal to the toSearchFor.
                foundIndex = nextLeft + 1;
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