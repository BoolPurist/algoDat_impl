using System.Text;

namespace algoDat_impl_library;

public static class SequenceUtils
{

    public static void Swap<T>(IList<T> array, int left, int right)
    {
        (array[left], array[right]) = (array[right], array[left]);
    }
    
    public static string SequenceToString<T>(IList<T> sequence, string separator = ", ")
    {
        var builder = new StringBuilder();

        builder.Append("[ ");
        int max = sequence.Count - 1;
        for (int appendIndex = 0; appendIndex < max; appendIndex++)
        {
            builder.Append($"{sequence[appendIndex]}{separator}");
        }

        if (sequence.Count == 0)
        {
            builder.Append(']');
        }
        else
        {
            builder.Append($"{sequence[max]} ]");
        }

        return builder.ToString();
    }

    public static void Reverse(int[] array)
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