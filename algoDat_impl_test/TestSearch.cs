using algoDat_impl_library.Searching;
using Xunit;

namespace algoDat_impl_test;

public class TestSearch
{
    [Theory]
    [MemberData(nameof(TestCasesLinearSearch))]
    public static void TestLinearSearch(int[] givenSequence, int toSearch, int expectedFoundIndex)
        => TestOneSearch(new LinearSearch(), givenSequence, toSearch, expectedFoundIndex);
    
    [Theory]
    [MemberData(nameof(TestCasesBinarySearch))]
    public static void TestBinarySearch(int[] givenSequence, int toSearch, int expectedFoundIndex)
        => TestOneSearch(new BinarySearch(), givenSequence, toSearch, expectedFoundIndex);
    
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

    public static TheoryData<int[], int, int> TestCasesBinarySearch
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
                new int[] {  },
                // toSearch
                -1,
                // expectedFoundIndex
                -1
            },
            {
                // givenSequence
                new [] { 1 },
                // toSearch
                -10,
                // expectedFoundIndex
                -1
            },
            {
                // givenSequence
                new [] { 1, 2, 3 },
                // toSearch
                2,
                // expectedFoundIndex
                1
            },
            {
                // givenSequence
                new [] { 1, 2, 3 },
                // toSearch
                1,
                // expectedFoundIndex
                0
            },
            {
                // givenSequence
                new [] { 1, 2, 3 },
                // toSearch
                3,
                // expectedFoundIndex
                2
            },
            {
                // givenSequence
                new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                // toSearch
                3,
                // expectedFoundIndex
                2
            },
            {
                // givenSequence
                new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                // toSearch
                9,
                // expectedFoundIndex
                8
            },
            {
                // givenSequence
                new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                // toSearch
                8,
                // expectedFoundIndex
                7
            },
            {
                // givenSequence
                new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                // toSearch
                6,
                // expectedFoundIndex
                5
            },
            {
                // givenSequence
                new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170  },
                // toSearch
                175,
                // expectedFoundIndex
                -1
            },
            {
                // givenSequence
                new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 },
                // toSearch
                110,
                // expectedFoundIndex
                6
            },
            {
                // givenSequence
                new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 },
                // toSearch
                170,
                // expectedFoundIndex
                9
            },
            {
                // givenSequence
                new [] { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 },
                // toSearch
                10,
                // expectedFoundIndex
                0
            },
            {
                // givenSequence
                new [] { 10, 10, 10, 10, 10 },
                // toSearch
                10,
                // expectedFoundIndex
                0
            },
            {
                // givenSequence
                new [] { 0, 10, 10, 20, 30 },
                // toSearch
                10,
                // expectedFoundIndex
                1
            },
            {
                // givenSequence
                new [] { 0, 5, 5, 10, 10, 20 },
                // toSearch
                10,
                // expectedFoundIndex
                3
            }
            
        };
}