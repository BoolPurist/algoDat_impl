using System.Text;

namespace algoDat_impl_console;

public static class SequenceUtils
{

    public static void Swap(int[] array, int left, int right)
    {
        (array[left], array[right]) = (array[right], array[left]);
    }

    public static string PrintSequence(int[] sequence)
    {
        var builder = new StringBuilder();

        builder.Append("[ ");
        foreach (var element in sequence)
        {
            builder.Append($"{element} ");
        }

        builder.Append("]");
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