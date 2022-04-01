using algoDat_impl_console.Searching;
using NuGet.Frameworks;
using Xunit;

namespace algoDat_impl_test;

public class TestSearch
{
    [Theory]
    [MemberData(nameof(TestCasesSearch))]
    public static void TestLinearSearch(int[] givenSequence, int toSearch, int expectedFoundIndex)
        => TestOneSearch(new LinearSearch(), givenSequence, toSearch, expectedFoundIndex);
    
    private static void TestOneSearch(ISearch searcher, int[] givenSequence, int toSearch, int expectedFoundIndex)
    {
        int actualFoundIndex = searcher.SearchFor(givenSequence, toSearch);
        Assert.Equal(expectedFoundIndex, actualFoundIndex);
    }

    public static TheoryData<int[], int, int> TestCasesSearch
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
            }
        };
}