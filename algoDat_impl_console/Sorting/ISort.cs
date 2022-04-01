namespace algoDat_impl_console.Sorting;

public interface ISort
{
    void Sort<T>(IList<T> toSort) where T : IComparable<T>;
}