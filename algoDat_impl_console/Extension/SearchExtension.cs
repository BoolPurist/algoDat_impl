using algoDat_impl_console.Searching;

namespace algoDat_impl_console.Extension;

public static class SearchExtension
{
    public static bool CheckFor<T>(this ISearch searcher, IList<T> toCheck, T toCheckFor) where T : IComparable<T>
        => searcher.SearchFor(toCheck, toCheckFor) >= 0;
}