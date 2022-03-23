using System;
using algoDat_impl_console;
using algoDat_impl_console.Sorting;
using Xunit;

namespace algoDat_impl_test;

public class TestSorting
{
    [Fact]
    public void Test_InsertionSort()
    {
        ISort insertionSort = new InsertionSort();
        TestsSortingCases(insertionSort);
    }

    private void TestsSortingCases(ISort sorter)
    {
        TestsSorting(sorter, new int[] {2, 6, 8});
        TestsSorting(sorter, new int[] {8, 5, 2});
    }

    private void TestsSorting(ISort sorter, int[] givenSeq)
    {
        // Set up
        var expectedSeq = new int[givenSeq.Length];
        Array.Copy(givenSeq, expectedSeq, givenSeq.Length);
        Array.Sort(expectedSeq);
        
        // Act
        sorter.Sort(givenSeq);

        // Assert
        for (int iArray = 0; iArray < expectedSeq.Length; iArray++)
        {
            Assert.Equal(expectedSeq[iArray], givenSeq[iArray]);
        }
    }
}