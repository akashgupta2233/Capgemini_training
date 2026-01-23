using System;
using System.Collections.Generic;

public class CharacterCounter
{
    public static Dictionary<char, int> CountChars(string input)
    {
        var counts = new Dictionary<char, int>();

        if (string.IsNullOrEmpty(input))
            return counts;

        foreach (char c in input)
        {
            if (counts.ContainsKey(c))
            {
                counts[c]++;
            }
            else
            {
                counts[c] = 1;
            }
        }

        return counts;
    }
}
