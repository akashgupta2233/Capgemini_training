using System;
using System.Collections.Generic;

public static class StringExtensions
{
    // The 'this' keyword makes this an extension method
    public static string[] CustomDistinctBy(this string[] items)
    {
        if (items == null || items.Length == 0) return new string[0];

        List<string> result = new List<string>();
        HashSet<string> seenIds = new HashSet<string>();

        foreach (string item in items)
        {
            // Split "id:name" into two parts
            string[] parts = item.Split(':');
            if (parts.Length < 2) continue;

            string id = parts[0];
            string name = parts[1];

            // HashSet.Add returns false if the item already exists
            if (seenIds.Add(id))
            {
                result.Add(name);
            }
        }

        return result.ToArray();
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        string[] input = { "1:Alice", "2:Bob", "1:Charlie", "3:David", "2:Eve" };
        
        // Calling the extension method
        string[] distinctNames = input.CustomDistinctBy();

        // Output: Alice, Bob, David
        Console.WriteLine(string.Join(", ", distinctNames));
    }
}
