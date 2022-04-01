using System.Linq;
using algoDat_impl_library.Extension;
using Xunit;

namespace algoDat_impl_test.Extension;

public class TestSequenceExtensions
{
    [Theory]
    [MemberData(nameof(TestCasesSplice))]
    public void TestSplice(int[] given, int givenStart, int givenCount, int[] expected)
    {
        int[] actual = given.Splice(givenStart, givenCount).ToArray();
        Assert.Equal(expected, actual);
    }
    
    public static TheoryData<int[], int, int, int[]> TestCasesSplice
        => new()
        {
            {
                // Given
                new [] { 2, 5 , 8 },
                // given start
                1,
                // given count
                1,
                // Expected
                new [] { 5 }
            },
            {
                // Given
                new [] { -2 },
                // given start
                0,
                // given count
                1,
                // Expected
                new [] { -2 }
            },
            {
                // Given
                new [] { 1, 2, 3, 4, 5 },
                // given start
                1,
                // given count
                3,
                // Expected
                new [] { 2, 3, 4, }
            }
        };
}