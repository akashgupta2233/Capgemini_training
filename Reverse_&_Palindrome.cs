using System;

class ReversePalindrome
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        int reversed = 0;

        while (temp > 0)
        {
            int digit = temp % 10;          
            reversed = reversed * 10 + digit; 
            temp /= 10;                    
        }

        Console.WriteLine("Reversed number: " + reversed);

        // Check palindrome
        if (num == reversed)
            Console.WriteLine(num + " is a palindrome.");
        else
            Console.WriteLine(num + " is not a palindrome.");
    }
}
