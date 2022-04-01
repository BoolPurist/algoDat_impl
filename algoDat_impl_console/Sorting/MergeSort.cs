using algoDat_impl_console.Extension;

namespace algoDat_impl_console.Sorting;

public class MergeSort : ISort
{
    public void Sort<T>(IList<T> toSort) where T : IComparable<T>
    {
        IList<T> sorted = GetSorted(toSort);

        for (int sortedI = 0; sortedI < sorted.Count; sortedI++)
        {
            toSort[sortedI] = sorted[sortedI];
        }
        
        static IList<T> GetSorted(IList<T> toDivide)
        {
            if (toDivide.Count < 2)
            {
                return toDivide;
            }

            int length = toDivide.Count; 
            int half = (length / 2);
            IList<T> left = GetSorted(toDivide.Splice(0, half).ToArray());
            IList<T> right = GetSorted(toDivide.Splice(half, length).ToArray());
            
            return MergeSorted(left, right);
        }
    }

    public static T[] MergeSorted<T>(IList<T> left, IList<T> right) where T : IComparable<T>
    {
        var leftI = 0;
        var rightI = 0;
        var result = new T[left.Count + right.Count];

        {
            bool leftIsNotEmpty = leftI < left.Count;
            bool rightIsNotEmpty = rightI < right.Count;
            
            for (int resultI = 0; ( leftIsNotEmpty || rightIsNotEmpty ); resultI++)
            {
                if ( leftIsNotEmpty && rightIsNotEmpty )
                {
                    bool leftComesIn = left[leftI].IsLessThan(right[rightI]); 
                    result[resultI] = leftComesIn ? left[leftI++] : right[rightI++];

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
                    result[resultI] = left[leftI++];
                    leftIsNotEmpty = leftI < left.Count;
                }
                else
                {
                    // rightIsNotEmpty
                    result[resultI] = right[rightI++];
                    rightIsNotEmpty = rightI < right.Count;
                }
            }
        }
        
        return result;
    }

}