using algoDat_impl_library.Sorting.SortingWithCounting;
using Xunit;

namespace algoDat_impl_test.TestForSortingWithCounting;

public class TestRadix
{
    [Theory]
    [MemberData(nameof(TestCasesRadixSort))]
    public void TestRadixSort(int[] toSort)
    {
        var expected = TestUtility.GetSortedCopy(toSort);
        Radix.Sort(toSort);
        Assert.Equal(expected, toSort);
    }

    public static TheoryData<int[]> TestCasesRadixSort()
        => new()
        {
            new int[]{ 45, -41, -1, 35, 45646, 56, 999 , 98 },
            new int[] { 78, -45, 20, -11 }
        };
}