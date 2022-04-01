using algoDat_impl_library.Extension;
using algoDat_impl_library.Searching;
using Xunit;
using Moq;

namespace algoDat_impl_test.Extension;

public class TestSearchExtension
{

    [Theory]
    [MemberData(nameof(TestCasesCheckFor))]
    public void TestCheckFor(int[] givenInput, int foundIndex, bool expected)
    {
        var fakeSearcher = new Mock<ISearch>();
        fakeSearcher
            .Setup(faker => faker.SearchFor(It.IsAny<int[]>(), It.IsAny<int>()))
            .Returns(foundIndex);
        bool actual = fakeSearcher.Object.CheckFor(givenInput, foundIndex);
        Assert.Equal(expected, actual);
    }

    public static TheoryData<int[], int, bool> TestCasesCheckFor
        => new()
        {
            {
                // givenInput
                new int[3],
                // fake foundIndex
                2,
                // expected
                true
            },
            {
                // givenInput
                new int[3],
                // fake foundIndex
                -1,
                // expected
                false
            }
        };
}



