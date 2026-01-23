using System;
using System.Text;
using System.Globalization;

public class InventoryManager
{
    public static string CleanProductName(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        // 1. Remove duplicate consecutive characters
        StringBuilder sb = new StringBuilder();
        sb.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                sb.Append(input[i]);
            }
        }

        // 2. Trim extra spaces
        string cleaned = sb.ToString().Trim();

        // 3. Convert to Title Case
        // We use ToLower() first because ToTitleCase doesn't change 
        // words that are already all-uppercase.
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(cleaned.ToLower());
    }
}
