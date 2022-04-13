using Xunit;
using algoDat_impl_library.Sorting.SortingWithCounting;

namespace algoDat_impl_test.TestForSortingWithCounting;

public class TestCountSort
{
    [Theory]
    [MemberData(nameof(TestCasesCountSort))]
    public void ShouldSort(int[] toSort, int givenMax)
    {
        var expected = TestUtility.GetSortedCopy(toSort);
        new CountSort(givenMax).Sort(toSort);
        
        Assert.Equal(expected, toSort);
    }

    public static TheoryData<int[] /* toSort */, int /* givenMax */> TestCasesCountSort()
        => new()
        {
            {
                new[] { 2, 1, 3 },
                3
            },
            {
                new[] { 0 },
                1
            },
            {
                new[] { 0, 1, 0 },
                1
            },
            {
                new[] { 3, 0, 1, 1, 10, 0, 4, 0, 1, 0, 6, 1, 0, 3, 7, 6, 8, 2, 2, 8 },
                10
            },
            {
                new[] { 1, 2, 3, 1, 5 },
                5
            }
            
            // 1, 2, 3, 1, 5
            
        };
}