using System.Xml.Xsl;

namespace algoDat_impl_console;

public static class Comparing
{
    public static bool IsLessThan<T>(T left, T right) where T : IComparable<T>
        => left.CompareTo(right) < 0;

    public static bool IsGreaterThan<T>(T left, T right) where T : IComparable<T>
        => left.CompareTo(right) > 0;

}