namespace algoDat_impl_library.Extension;

public static class Comparing
{
    public static bool IsLessThan<T>(this IComparable<T> left, T right) where T : IComparable<T>
        => left.CompareTo(right) < 0;

    public static bool IsGreaterThan<T>(this IComparable<T> left, T right) where T : IComparable<T>
        => left.CompareTo(right) > 0;

    public static bool IsEqual<T>(this IComparable<T> left, T right) where T : IComparable<T>
        => left.CompareTo(right) == 0;

}