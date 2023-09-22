using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        bool areAnagrams = AreAnagrams(str1, str2);

        Console.WriteLine($"'{str1}' and '{str2}' are {(areAnagrams ? "anagrams" : "not anagrams")}");
    }

    static bool AreAnagrams(string str1, string str2)
    {
        // Remove spaces and convert both strings to lowercase
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        // Check if the lengths are the same
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Create dictionaries to count character frequencies
        Dictionary<char, int> charCount1 = new Dictionary<char, int>();
        Dictionary<char, int> charCount2 = new Dictionary<char, int>();

        // Populate charCount1
        foreach (char c in str1)
        {
            if (charCount1.ContainsKey(c))
            {
                charCount1[c]++;
            }
            else
            {
                charCount1[c] = 1;
            }
        }

        // Populate charCount2
        foreach (char c in str2)
        {
            if (charCount2.ContainsKey(c))
            {
                charCount2[c]++;
            }
            else
            {
                charCount2[c] = 1;
            }
        }

        // Compare the two dictionaries to check for anagrams
        return charCount1.SequenceEqual(charCount2);
    }
}
