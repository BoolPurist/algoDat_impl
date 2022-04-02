using System;
using System.Collections.Generic;
using algoDat_impl_library;
using algoDat_impl_library.Sorting;
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

    [Fact]
    public void TestReverse()
    {
        for (int i = 0; i < TestCasesReverse.Length; i++)
        {
            int[] given = TestCasesReverse[i].given;
        
            int[] expected = new int[given.Length];
            Array.Copy(given, expected, given.Length);
            Array.Reverse(expected);
        
            SequenceUtils.Reverse(given);
        
            Assert.Equal(expected, given);
        }
    }

    [Theory]
    [MemberData(nameof(TestCasesMergeSorted))]
    public static void TestMergeSorted(int[] left, int[] right, int[] expected)
    {
        var result = MergeSort.CombineSorted(left, right);
        
        Assert.Equal(expected, result);

    }

    [Theory]
    [MemberData(nameof(TestCasePrintSequence))]
    public static void TestPrintSequence(int[] given, string expected)
    {
        string actual = SequenceUtils.SequenceToString(given);
        Assert.Equal(expected, actual);
    }

    public static TheoryData<int[], int[], int[]> TestCasesMergeSorted
        => new()
        {
            {
                new int[] { 1, 2, 5 }, 
                new int[] { -2, -1, 5 }, 
                new int[] { -2, -1, 1, 2, 5, 5 }
            },
            {
                new int[] { 1, 1, 5 },
                new int[] { 2, 4, },
                new int[] { 1, 1, 2, 4, 5 }
            },
            {
                new int[] { int.MinValue, -899, 789  },
                new int[] { },
                new int[] { int.MinValue, -899, 789 }
            },
            {
                new int[] { },
                new int[] { int.MinValue, -899, 789, 2, Int32.MaxValue },
                new int[] { int.MinValue, -899, 789, 2, Int32.MaxValue }
            },
            {
                new int[] { },
                new int[] { },
                new int[] { }
            }
            
        };

    public static TheoryData<int[], string> TestCasePrintSequence
        => new()
        {
            {
                new int[] { 2, 5, 5}, 
                "[ 2, 5, 5 ]"
            },
            {
                new int[] { }, 
                "[ ]"
            }
        };



    private record TestCaseReverse(int[] given);

    private record  TestCaseSwap(int[] ToSwap, int Left, int Right, int[] Expected);

    private static readonly TestCaseSwap[] TestCasesSwap = new TestCaseSwap[]
    {
        new(new int[] { 2, 4 }, 0, 1, new int[] { 4, 2 }),
        new(new int[] { 2, 4 }, 0, 0, new int[] { 2, 4 }),
        new(new int[] { 2, 4, 8, 7 }, 0, 3, new int[] { 7, 4, 8, 2 }) 
    };

    private static readonly TestCaseReverse[] TestCasesReverse = new TestCaseReverse[]
    {
        new(new[] { 1, 3, 5, 7 })
    };
}