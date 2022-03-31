namespace algoDat_impl_console.Sorting;

public class MergeSort : ISort
{
    public void Sort(int[] toSort)
    {
        throw new NotImplementedException();
    }

    public static int[]? MergeSorted(int[] left, int[] right)
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