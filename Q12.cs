using System;

public class ArrayProcessor
{
    public int SumPositiveUntilZero(int[] nums)
    {
        int sum = 0;

        foreach (int n in nums)
        {
            if (n == 0)
            {
                // Stop processing the array entirely
                break;
            }

            if (n < 0)
            {
                // Skip this number and go to the next iteration
                continue;
            }

            // Accumulate positive integers
            sum += n;
        }

        return sum;
    }
}
