using System;
using algoDat_impl_library;
using Xunit;

namespace algoDat_impl_test.Utility;

public class TestNumberUtility
{
    [Theory]
    [MemberData(nameof(TestCasesNumberUtility))]
    public void TestGetDigitAt(int toExtractFrom, int extractIndex, int expectedDigit)
    {
        int actual = NumberUtility.GetDigitAt(toExtractFrom, extractIndex);
        Assert.Equal(expectedDigit, actual);
    }

    public static TheoryData<int /* toExtractFrom */, int /* extractIndex */, int /* expectedDigit */>
        TestCasesNumberUtility
        => new()
        {
            { 754, 2, 7 },
            { 728, 0, 8 },
            { 4, 0, 4 },
            { 24, 8, 0 },
            { 204, 1, 0 },
            { 1000, 8, 0 },
            { 2147483647, 8, 1 },
            { 2147483647, 9 ,2 }
        };
}