using algoDat_impl_library.Extension;

namespace algoDat_impl_library.Sorting;

public class MergeSort : ISort
{
    public void Sort<T>(IList<T> toSort) where T : IComparable<T>
    {
        RecursiveMergeSort(toSort, true);
        
        IList<T> RecursiveMergeSort(IList<T> toDivide, bool rootCall = false)
        {
            if (toDivide.Count < 2)
            {
                return toDivide;
            }
            
            int length = toDivide.Count; 
            int half = (length / 2);
                
            IList<T> left = RecursiveMergeSort(toDivide.Splice(0, half).ToArray());
            IList<T> right = RecursiveMergeSort(toDivide.Splice(half, length).ToArray());
            
            if (rootCall)
            {
                CombineSortedInto(left, right, toSort);
                return toSort;
            }
            else
            {
                return MergeSort.CombineSorted(left, right);
            }
            
        }
        
    }

    /// <summary>
    /// Last 2 sorted section are merged into the initial unsorted sequence to prevent
    /// Otherwise one more copy from sorted version to the unsorted version would be needed.  
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <param name="dest"></param>
    /// <typeparam name="T"></typeparam>
    public static void CombineSortedInto<T>(
        IList<T> left, 
        IList<T> right,
        IList<T> dest
        ) where T : IComparable<T>
    {
        var leftI = 0;
        var rightI = 0;

        {
            bool leftIsNotEmpty = leftI < left.Count;
            bool rightIsNotEmpty = rightI < right.Count;
            
            for (int destI = 0; ( leftIsNotEmpty || rightIsNotEmpty ); destI++)
            {
                if ( leftIsNotEmpty && rightIsNotEmpty )
                {
                    bool leftComesIn = left[leftI].IsLessThan(right[rightI]); 
                    dest[destI] = leftComesIn ? left[leftI++] : right[rightI++];

                    if (leftComesIn)
                    {
                        leftIsNotEmpty = leftI < left.Count;
                    }
                    else
                    {
                        rightIsNotEmpty = rightI < right.Count;
                    }
                }
                else if ( leftIsNotEmpty )
                {
                    dest[destI] = left[leftI++];
                    leftIsNotEmpty = leftI < left.Count;
                }
                else
                {
                    // rightIsNotEmpty
                    dest[destI] = right[rightI++];
                    rightIsNotEmpty = rightI < right.Count;
                }
            }
        }
    }

    public static IList<T> CombineSorted<T>(IList<T> left, IList<T> right) where T : IComparable<T>
    {
        var result = new T[left.Count + right.Count];

        CombineSortedInto(left, right, result);
        
        return result;
    }

    
}