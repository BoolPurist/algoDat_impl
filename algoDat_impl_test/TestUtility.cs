using System;

namespace algoDat_impl_test;

public static class TestUtility
{
    public static T[] GetSortedCopy<T>(T[] toCopyAndSort)
    {
        var copy = new T[toCopyAndSort.Length];
        Array.Copy(toCopyAndSort, copy, toCopyAndSort.Length);
        Array.Sort(copy);
        return copy;
    }
}