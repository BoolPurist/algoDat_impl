namespace algoDat_impl_console;

public static class SequenceUtils
{

    public static void Swap(int[] array, int left, int right)
    {
        (array[left], array[right]) = (array[right], array[left]);
    }

    public static void InPlaceReverse(int[] array)
    {
        int i = 0;
        int j = array.Length - 1;
        while (i < j)
        {
            Swap(array, i , j);
            i++;
            j--;
        }
    }
    
    
}