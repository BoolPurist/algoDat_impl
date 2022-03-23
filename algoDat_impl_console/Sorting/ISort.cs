namespace algoDat_impl_console.Sorting;

public interface ISort
{
    void Sort<TElement>(TElement[] toSort) where TElement : IComparable<TElement>;
}