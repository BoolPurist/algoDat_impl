namespace algoDat_impl_console.Searching;

public interface ISearch
{
    int SearchFor<T>(IList<T> toSearchThrough, T toSearchFor) where T : IComparable<T>;
    
}