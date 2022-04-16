using System;
using algoDat_impl_library;
using Xunit;

namespace algoDat_impl_test.Utility;

public class TestNumberUtility
{
    [Theory]
    [MemberData(nameof(TestCasesGetDigitAt))]
    public void TestGetDigitAt(int toExtractFrom, int extractIndex, int expectedDigit)
    {
        int actual = NumberUtility.GetDigitAt(toExtractFrom, extractIndex);
        Assert.Equal(expectedDigit, actual);
    }

    [Theory]
    [MemberData(nameof(TestCasesGetDigitCount))]
    public void TestGetDigitCount(int givenNumber, int expected)
    {
        int actual = NumberUtility.GetDigitCount(givenNumber);
        Assert.Equal(expected, actual);
    }

    public static TheoryData<int /* toExtractFrom */, int /* extractIndex */, int /* expectedDigit */>
        TestCasesGetDigitAt
        => new()
        {
            { 754, 2, 7 },
            { 728, 0, 8 },
            { 4, 0, 4 },
            { 24, 8, 0 },
            { 204, 1, 0 },
            { 1000, 8, 0 },
            { -1800, 2, -8 },
            { 2147483647, 8, 1 },
            { 2147483647, 9 ,2 }
        };

    public static TheoryData<int /* givenNumber */, int /* expected */> 
        TestCasesGetDigitCount
        => new()
        {
            { 1, 1 },
            { 0, 1 },
            { -1, 1 },
            { -1004, 4 },
            { 5821744, 7 },
            { Int32.MaxValue, 10 },
            { Int32.MinValue, 10 }
        };
}