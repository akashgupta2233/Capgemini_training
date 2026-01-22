using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MahirlAssignment
{
    public static string ProcessWords(string word1, string word2)
    {
        string vowels = "aeiou";
        
        // 1. Identify consonants in word2 (case-insensitive)
        var word2Consonants = word2.ToLower()
            .Where(c => !vowels.Contains(c))
            .ToHashSet();

        // 2. Task 1: Filter word1
        StringBuilder filtered = new StringBuilder();
        foreach (char c in word1)
        {
            char lowerC = char.ToLower(c);
            bool isVowel = vowels.Contains(lowerC);
            
            // Keep if it's a vowel OR a consonant NOT in word2
            if (isVowel || !word2Consonants.Contains(lowerC))
            {
                filtered.Append(c);
            }
        }

        // 3. Task 2: Remove consecutive duplicates
        if (filtered.Length == 0) return "";

        StringBuilder result = new StringBuilder();
        result.Append(filtered[0]);

        for (int i = 1; i < filtered.Length; i++)
        {
            // Only append if it's not the same as the previous character
            if (filtered[i] != filtered[i - 1])
            {
                result.Append(filtered[i]);
            }
        }

        return result.ToString();
    }
}
