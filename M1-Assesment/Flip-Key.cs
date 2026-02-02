using System;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();

        Program p = new Program();
        string result = p.CleanseAndInvert(input);

        if (string.IsNullOrEmpty(result))
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("The generated key is - " + result);
        }
    }

    public string CleanseAndInvert(string input)
    {
        // 1. Null check and length check (at least 6 characters)
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return "";
        }

        // 2. Space, Digit, or Special Character check
        // Char.IsLetter ensures only 'a-z' or 'A-Z' are allowed
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return "";
            }
        }

        // Password Generation Logic:
        // A) Convert to lowercase
        string processed = input.ToLower();

        // B) Remove characters with even ASCII values
        StringBuilder oddAsciiOnly = new StringBuilder();
        foreach (char c in processed)
        {
            if ((int)c % 2 != 0)
            {
                oddAsciiOnly.Append(c);
            }
        }

        // C) Reverse the remaining characters
        char[] charArray = oddAsciiOnly.ToString().ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        // D) Convert even-positioned (0-based) characters to uppercase
        StringBuilder finalKey = new StringBuilder();
        for (int i = 0; i < reversed.Length; i++)
        {
            if (i % 2 == 0)
            {
                finalKey.Append(char.ToUpper(reversed[i]));
            }
            else
            {
                finalKey.Append(reversed[i]);
            }
        }

        return finalKey.ToString();
    }
}
