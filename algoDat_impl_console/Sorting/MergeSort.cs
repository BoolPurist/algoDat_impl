namespace algoDat_impl_console.Sorting;

public class MergeSort : ISort
{
    public void Sort(int[] toSort)
    {
        int[] sorted = GetSorted(toSort);

        for (int sortedI = 0; sortedI < sorted.Length; sortedI++)
        {
            toSort[sortedI] = sorted[sortedI];
        }
        
        static int[] GetSorted(int[] toDivide)
        {
            if (toDivide.Length < 2)
            {
                return toDivide;
            }

            int length = toDivide.Length; 
            int half = (length / 2);
            int[] left = GetSorted(toDivide[0..half]);
            int[] right = GetSorted(toDivide[half..length]);
            
            return MergeSorted(left, right);
        }
    }

    public static int[] MergeSorted(int[] left, int[] right)
    {
        var leftI = 0;
        var rightI = 0;
        var result = new int[left.Length + right.Length];

        {
            bool leftIsNotEmpty = leftI < left.Length;
            bool rightIsNotEmpty = rightI < right.Length;
            
            for (int resultI = 0; ( leftIsNotEmpty || rightIsNotEmpty ); resultI++)
            {
                if ( leftIsNotEmpty && rightIsNotEmpty )
                {
                    bool leftComesIn = left[leftI] < right[rightI]; 
                    result[resultI] = leftComesIn ? left[leftI++] : right[rightI++];

                    if (leftComesIn)
                    {
                        leftIsNotEmpty = leftI < left.Length;
                    }
                    else
                    {
                        rightIsNotEmpty = rightI < right.Length;
                    }
                }
                else if ( leftIsNotEmpty )
                {
                    result[resultI] = left[leftI++];
                    leftIsNotEmpty = leftI < left.Length;
                }
                else
                {
                    // rightIsNotEmpty
                    result[resultI] = right[rightI++];
                    rightIsNotEmpty = rightI < right.Length;
                }
            }
        }
        
        return result;
    }
}