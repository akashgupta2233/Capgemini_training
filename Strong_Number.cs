using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsStrongNumber(number))
        {
            Console.WriteLine($"{number} is a Strong Number!");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a Strong Number.");
        }
    }

    static bool IsStrongNumber(int n)
    {
        int original = n;
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += Factorial(digit);
            n /= 10;
        }

        return sum == original;
    }

    static int Factorial(int x)
    {
        int fact = 1;
        for (int i = 2; i <= x; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
