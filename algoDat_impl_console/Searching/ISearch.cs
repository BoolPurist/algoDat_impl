namespace algoDat_impl_console.Searching;

public interface ISearch
{
    int SearchFor<T>(IList<T> toSearchThrough) where T : IComparable<T>;
}