using System;
using algoDat_impl_library.Sorting;
using Xunit;

namespace algoDat_impl_test;

public class TestSorting
{
    
    [Fact]
    public void Test_QuickSort()
    {
        ISort quickSort = new QuickSort();
        TestsSortingCases(quickSort);
    }
    
    [Fact]
    public void Test_NaturalMergeSort()
    {
        ISort naturalMergeSort = new NaturalMergeSort();
        TestsSortingCases(naturalMergeSort);
    }
    
    [Fact]
    public void Test_SelectionSort()
    {
        ISort selectionSort = new SelectionSort();
        TestsSortingCases(selectionSort);
    }
    [Fact]
    public void Test_InsertionSort()
    {
        ISort insertionSort = new InsertionSort();
        TestsSortingCases(insertionSort);
    }
    
    [Fact]
    public void Test_BubbleSort()
    {
        ISort bubbleSort = new BubbleSort();
        TestsSortingCases(bubbleSort);
    }
    
    [Fact]
    public void Test_MergeSort()
    {
        ISort mergeSort = new MergeSort();
        TestsSortingCases(mergeSort);
    }
    
    [Fact]
    public void Test_HeapSort()
    {
        ISort mergeSort = new HeapSort();
        TestsSortingCases(mergeSort);
    }
    
    private void TestsSortingCases(ISort sorter)
    {
        TestsSorting(sorter, new int[] { 2, 6, 8 });
        TestsSorting(sorter, new int[] { 89, 8, 2 });
        TestsSorting(sorter, new int[] { 1 });
        TestsSorting(sorter, new int[] { 8, 5, 2 });
        TestsSorting(sorter, new int[] { 4, 2, 3, 1 });
        TestsSorting(sorter, new int[] { 4, -2, 3, -1 });
        TestsSorting(sorter, new int[] {-2, -1, 3, 4} );
        TestsSorting(sorter, new int[] { 6, 5, 5, 6 });
        TestsSorting(sorter, new int[] { 
            129, 43, -159, 183, 834, -352, 558, 419, -168, 963, -933, -951, -561, 
            438, 324, -973, 57, -929, 863, 792, -970, 899, 773, 168, 223, 275, 
            -596, -62, -881, -129, 480, -130, -509, -868, -61, 121, 962, -272, 
            923, 615, -406, 384, 112, 588, 387, -883, -827, -228, -290, 981, 
            201, 740, 60, -199, 913, -871, -24, -657, -95, 49, 199, 349, -365, 
            -249, 539, 5, 934, 477, 288, -75, -44, 850, -928, 156, -397, 72, 
            -381, 537, 901, -180, -264, -570, -112, -498, 17, 612, 555, 10, -470, 
            -708, 361, -91, 422, -330, 850, 192, 433, -265, 439, 10
        });
        TestsSorting(sorter, new int[] {int.MaxValue, -1, int.MinValue, 4, -89, 0});
    }

    private void TestsSorting(ISort sorter, int[] givenSeq)
    {
        // Set up
        var expectedSeq = TestUtility.GetSortedCopy(givenSeq);
        
        // Act
        sorter.Sort(givenSeq);

        // Assert
        for (int iArray = 0; iArray < expectedSeq.Length; iArray++)
        {
            Assert.Equal(expectedSeq[iArray], givenSeq[iArray]);
        }
    }
}