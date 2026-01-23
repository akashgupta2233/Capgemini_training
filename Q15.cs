using System;
using System.Linq;

public class StatisticsHelper
{
    public static double? GetAverage(double?[] values)
    {
        // 1. Filter out null values
        var nonNullValues = values
            .Where(v => v.HasValue)
            .Select(v => v.Value)
            .ToArray();

        // 2. If no non-null values exist, return null
        if (nonNullValues.Length == 0)
        {
            return null;
        }

        // 3. Calculate average
        double average = nonNullValues.Average();

        // 4. Round to 2 decimals using AwayFromZero
        // Example: 1.255 becomes 1.26
        return Math.Round(average, 2, MidpointRounding.AwayFromZero);
    }
}
