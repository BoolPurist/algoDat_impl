namespace algoDat_impl_console.Sorting;

public interface ISort
{
    void Sort<T>(T[] toSort) where T : IComparable<T>;
}