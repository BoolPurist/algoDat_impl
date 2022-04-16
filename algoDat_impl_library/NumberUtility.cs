namespace algoDat_impl_library;

public static class NumberUtility
{
    static NumberUtility()
    {
        int maxLength = Int32.MaxValue.ToString().Length + 1;
        List<int> truncates = new();
        
        for (int truncateI = 1, truncateFactor = 1; truncateI < maxLength; truncateFactor *= 10, truncateI++)
        {
            truncates.Add(truncateFactor);
        }

        _sForTruncateAt = truncates.ToArray();
    }
    
    private static readonly int[] _sForTruncateAt;
    
    /// <summary>
    /// Returns the number at a certain digit of a number
    /// </summary>
    /// <param name="toExtractFrom">
    /// Number to extract the digit from.
    /// </param>
    /// <param name="index">
    /// Which digit to get number from. Expected values are between 0 to 9
    /// </param>
    /// <returns>
    /// Returns the digit value between 0 and 9 at a certain spot.
    /// </returns>
    /// <example>
    /// NumberUtility.GetDigitAt(148, 1) => 4
    /// </example>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown if the parameter index is outside of valid range between 0 and 9.
    /// </exception>
    public static int GetDigitAt(int toExtractFrom, int index)
    {
        if (index < 0 || index > 9)
        {
            throw new ArgumentOutOfRangeException(nameof(index), index, $"parameter is outside of valid range between 0 between 9");
        }
        return (toExtractFrom / _sForTruncateAt[index]) % 10;
    }

    public static int GetDigitCount(int number)
    {
        int counter = 1;
        const int factor = 10;
        int currentDivision = number / factor; 
        
        while (currentDivision != 0)
        {
            counter++;
            currentDivision /= factor;
        }

        return counter;
    }
}