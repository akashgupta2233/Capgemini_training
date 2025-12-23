using System;

class GCD_LCM
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = 1;

        for (int i = 1; i <= a && i <= b; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                gcd = i;
            }
        }

        int lcm = (a * b) / gcd;

        Console.WriteLine("GCD of " + a + " and " + b + " is: " + gcd);
        Console.WriteLine("LCM of " + a + " and " + b + " is: " + lcm);
    }
}
