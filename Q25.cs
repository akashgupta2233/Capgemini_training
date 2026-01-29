using System;

public class Program
{
    public static void Main()
    {
        // Example input with mixed types
        object[] values = { 10, "Hello", true, null, 25, 5.5, 100 };
        
        int result = SumIntegers(values);
        Console.WriteLine($"Total Sum: {result}"); // Output: 135
    }

    public static int SumIntegers(object[] values)
    {
        int sum = 0;

        // Ensure the input isn't null
        if (values == null) return 0;

        foreach (var item in values)
        {
            // Pattern matching: 
            // Checks if 'item' is an int and assigns it to 'x' in one step
            if (item is int x)
            {
                sum += x;
            }
        }

        return sum;
    }
}
