using System;

class Program
{
    static void Main()
    {
        // Read input and split by space
        string[] input = Console.ReadLine().Split(' ');
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int luckyCount = 0;

        for (int i = m; i <= n; i++)
        {
            // Requirement 1: Non-prime positive integer
            if (!IsPrime(i) && i > 0)
            {
                // Requirement 2: S(x * x) == S(x) * S(x)
                long sumX = SumDigits(i);
                long sumXSquared = SumDigits((long)i * i);

                if (sumXSquared == (sumX * sumX))
                {
                    luckyCount++;
                }
            }
        }

        Console.WriteLine(luckyCount);
    }

    // Helper to calculate the sum of digits
    static long SumDigits(long num)
    {
        long sum = 0;
        num = Math.Abs(num);
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    // Helper to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(num));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
