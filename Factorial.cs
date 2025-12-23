using System;
using System.Numerics; 

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger result = Factorial(n);

        Console.WriteLine($"{n}! = {result}");
    }

    static BigInteger Factorial(int n)
    {
        BigInteger fact = 1;

        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }

        return fact;
    }
}
