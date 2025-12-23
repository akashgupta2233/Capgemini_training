using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();

        int decimalValue = 0;
        int baseValue = 1; 

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                decimalValue += baseValue;
            }
            baseValue *= 2; 
        }

        Console.WriteLine("Decimal equivalent: " + decimalValue);
    }
}
