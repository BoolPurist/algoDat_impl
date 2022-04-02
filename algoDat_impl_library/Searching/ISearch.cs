namespace algoDat_impl_library.Searching;

public interface ISearch
{
    /// <summary>
    /// Finds the index of the 1. value which equals to the wanted value from left to right. 
    /// </summary>
    /// <param name="toSearchThrough">
    /// Sequence to search in
    /// </param>
    /// <param name="toSearchFor">
    /// Value to look for
    /// </param>
    /// <typeparam name="T"></typeparam>
    /// <returns>
    /// Returns the index of the 1. value which equals to the wanted value from left to right.
    /// Returns -1 If value is not in the sequence or the sequence is empty. 
    /// </returns>
    int SearchFor<T>(IList<T> toSearchThrough, T toSearchFor) where T : IComparable<T>;
    
    
}