namespace algoDat_impl_console.Extension;

public static class SequenceExtensions
{
    public static IEnumerable<T> Splice<T>(this IEnumerable<T> toSplice, int start, int count)
    {
        return toSplice.Skip(start).Take(count);
    }
}