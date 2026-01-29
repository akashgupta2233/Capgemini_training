using System;

public class Program
{
    public static void Main()
    {
        // Testing with your example
        Console.WriteLine(FormatTime(125)); // Output: 2:05
        Console.WriteLine(FormatTime(60));  // Output: 1:00
        Console.WriteLine(FormatTime(9));   // Output: 0:09
    }

    public static string FormatTime(int totalSeconds)
    {
        // 1. Calculate the minutes using integer division
        int minutes = totalSeconds / 60;

        // 2. Calculate the remaining seconds using the modulo (%) operator
        int seconds = totalSeconds % 60;

        // 3. Format the string
        // ":D2" ensures the seconds always have at least 2 digits (adds a leading zero)
        return $"{minutes}:{seconds:D2}";
    }
}
