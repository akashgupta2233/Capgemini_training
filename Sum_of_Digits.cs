using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int digitalRoot = GetDigitalRoot(number);

        Console.WriteLine($"Digital Root of {number} = {digitalRoot}");
    }

    static int GetDigitalRoot(int n)
    {
        while (n >= 10) 
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;       
            }
            n = sum; 
        }
        return n;
    }
}
