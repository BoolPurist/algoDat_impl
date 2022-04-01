namespace algoDat_impl_library.Extension;

public static class StackExtension
{
    public static bool IsEmpty<T>(this Stack<T> stack)
        => stack.Count != 0;
}