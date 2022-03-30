using System;
using algoDat_impl_console;
using System.Collections.Generic;
using Xunit;


namespace algoDat_impl_test;

public class TestSequenceUtilis
{
    [Fact]
    public void TestSwap()
    {
        for (int i = 0; i < TestCasesSwap.Length; i++)
        {
            var currentCase = TestCasesSwap[i];
            SequenceUtils.Swap(currentCase.ToSwap, currentCase.Left, currentCase.Right);
            Assert.Equal(currentCase.Expected, currentCase.ToSwap);
        }
    }
    private record  TestCaseSwap(int[] ToSwap, int Left, int Right, int[] Expected);

    private static readonly TestCaseSwap[] TestCasesSwap = new TestCaseSwap[]
    {
        new(new int[] { 2, 4 }, 0, 1, new int[] { 4, 2 }),
        new(new int[] { 2, 4 }, 0, 0, new int[] { 2, 4 }),
        new(new int[] { 2, 4, 8, 7 }, 0, 3, new int[] { 7, 4, 8, 2 }) 
    };
}