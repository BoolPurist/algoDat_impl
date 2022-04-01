using algoDat_impl_library.Searching;
using Xunit;

namespace algoDat_impl_test;

public class TestSearch
{
    [Theory]
    [MemberData(nameof(TestCasesLinearSearch))]
    public static void TestLinearSearch(int[] givenSequence, int toSearch, int expectedFoundIndex)
        => TestOneSearch(new LinearSearch(), givenSequence, toSearch, expectedFoundIndex);
    
    private static void TestOneSearch(ISearch searcher, int[] givenSequence, int toSearch, int expectedFoundIndex)
    {
        int actualFoundIndex = searcher.SearchFor(givenSequence, toSearch);
        Assert.Equal(expectedFoundIndex, actualFoundIndex);
    }

    public static TheoryData<int[], int, int> TestCasesLinearSearch
        => new()
        {
            {
                // givenSequence
                new [] { 1 },
                // toSearch
                1,
                // expectedFoundIndex
                0
            },
            {
                // givenSequence
                new [] { 1 },
                // foundIndex
                0,
                // expected
                -1
            },
            {
                new [] { 1, 2, 3 },
                2,
                1
            },
            {
                new [] { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 },
                110,
                6
            },
            {
                new [] {10, 20, 80, 30, 60, 50, 110, 100, 130, 170},
                175,
                -1
                
            },
            {
                new int[] { },
                78,
                -1
            },
            {
                new int[] { -798 },
                -798,
                0
            },
            {
                new int[] { -798, 789, 456 },
                456,
                2
            },
            {
                new int[] { -798, 1, 1, 456 },
                1,
                1
            }
        };
}