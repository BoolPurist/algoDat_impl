using System.Diagnostics;

namespace algoDat_impl_library.Sorting.SortingWithCounting;

public static class Radix
{

    public static void Sort(IList<int> numbers)
    {
        // Index 0 is unused, length starts with 1.
        // It is ignored to avoid the offsetting of the index by one.
        var groupedByCount = new List<int>[33];
        var groupedByCountNegative = new List<int>[33];

        // Initialize the lists for the different groups for the length of a number.
        for (int index = 1; index < groupedByCount.Length; index++)
        {
            groupedByCount[index] = new List<int>();
            groupedByCountNegative[index] = new List<int>();
        }

        // Put the unsorted numbers into the respective groups.
        foreach (var toInsertInGroup in numbers)
        {
            int digitCount = NumberUtility.GetDigitCount(toInsertInGroup);
            if (toInsertInGroup < 0)
            {
                // Negative numbers will be put in different groups. This important for 
                // the later merging into the final sorted sequence. 
                groupedByCountNegative[digitCount].Add(toInsertInGroup);
            }
            else
            {
                groupedByCount[digitCount].Add(toInsertInGroup);
            }
        }

        // All groups will be merged into this list.
        var sortedGroups = new List<int>();
        
        // Sort negative numbers
        // We start from the back. Negative numbers with higher amount come before
        // others negative  numbers with smaller amount. This way the order of merging
        // respects this fact.
        for (int groupIndex = groupedByCountNegative.Length - 1; groupIndex > 0; groupIndex--)
        {
            var currentGroup = groupedByCountNegative[groupIndex];
            // Check if any number of this length from numbers was found.
            if (currentGroup.Count != 0)
            {
                SortWithOneLength(currentGroup);
                sortedGroups.AddRange(currentGroup);
            }
        }

        // Sort positive numbers. We start from the start. Positive Numbers with smaller 
        // amount should be merged before the ones with higher amounts.
        for (int groupIndex = 1; groupIndex < groupedByCount.Length; groupIndex++)
        {
            var currentGroup = groupedByCount[groupIndex];
            // Check if any number of this length from numbers was found.
            if (currentGroup.Count != 0)
            {
                SortWithOneLength(currentGroup);
                sortedGroups.AddRange(currentGroup);
            }
        }

        // Overwriting unsorted sequence with sorted one.
        for (int insertIndex = 0; insertIndex < numbers.Count; insertIndex++)
        {
            numbers[insertIndex] = sortedGroups[insertIndex];
        }
    }

    private static void SortWithOneLength(IList<int> numbers)
    {
        int length = numbers[0].ToString().Length;

        for (int index = 0; index < length; index++)
        {
            SortAtColumn(numbers, index);
        }
    }

    private static void SortAtColumn(IList<int> numbers, int column)
    {
        const int offset = 9;
        
        var digitCounting = new int[19];
        digitCounting[0] = -1;
        
        for (int index = 0; index < numbers.Count; index++)
        {
            int currentNumber = numbers[index];
            int digitValue = NumberUtility.GetDigitAt(currentNumber, column);
            digitCounting[digitValue + offset]++;
        }
        
        CountSort.AddCountingUp(digitCounting);
        
        int[] result = new int[numbers.Count];
        for (int i = numbers.Count - 1; i > -1; i--)
        {
            int toInsert = numbers[i];
            int digitValue = NumberUtility.GetDigitAt(toInsert, column);
            int absoluteDigitValue = digitValue + offset;
            int insertIndex = digitCounting[absoluteDigitValue];
            result[insertIndex] = toInsert;
            digitCounting[absoluteDigitValue]--;
        }
        
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = result[i];
        }
    }
}