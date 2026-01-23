using System;

public class TokenSummator
{
    public static int SumValidIntegers(string[] tokens)
    {
        int totalSum = 0;

        foreach (string token in tokens)
        {
            // int.TryParse returns true if the string is a valid 32-bit int.
            // It returns false for letters, symbols, nulls, or values > 2,147,483,647.
            if (int.TryParse(token, out int parsedValue))
            {
                totalSum += parsedValue;
            }
        }

        return totalSum;
    }
}
