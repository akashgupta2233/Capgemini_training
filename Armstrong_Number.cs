using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        int digits = num.ToString().Length; 
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10; 
            sum += (int)Math.Pow(digit, digits); 
            temp /= 10; 
        }

        if (sum == num)
            Console.WriteLine(num + " is an Armstrong number.");
        else
            Console.WriteLine(num + " is not an Armstrong number.");
    }
}
