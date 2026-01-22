using System;

public class MathUtils
{
    public static int GetLargest(int a, int b, int c)
    {
        int largest;

        if (a >= b && a >= c)
        {
            // a is greater than or equal to both b and c
            largest = a;
        }
        else if (b >= a && b >= c)
        {
            // b is greater than or equal to both a and c
            largest = b;
        }
        else
        {
            // If neither a nor b is the largest, c must be
            largest = c;
        }

        return largest;
    }
}
