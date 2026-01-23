using System;

public class MathUtilities
{
    public int ComputeGCD(int a, int b)
    {
        // Base Case: When the second number reaches 0, 
        // the first number is the GCD.
        if (b == 0)
        {
            return a;
        }

        // Recursive Step: Call the function again with (b, a % b)
        return ComputeGCD(b, a % b);
    }
}
