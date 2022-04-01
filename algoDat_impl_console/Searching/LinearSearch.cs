using algoDat_impl_console.Extension;

namespace algoDat_impl_console.Searching;

public class LinearSearch : ISearch
{
    public int SearchFor<T>(IList<T> toSearchThrough, T searchFor) where T : IComparable<T>
    {
        for (int index = 0; index < toSearchThrough.Count; index++)
        {
            T inspectedValue = toSearchThrough[index];
            if (searchFor.IsEqual(inspectedValue))
            {
                return index;
            }
        }

        return -1;
    }
}