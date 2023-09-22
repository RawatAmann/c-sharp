using System;
using System.Globalization;
using System.Text;

public class Program
{
    public static void Main()
    {
        string input = "hello world example";
        string result = CapitalizeFirstAndLastCharacter(input);

        Console.WriteLine("Original String: " + input);
        Console.WriteLine("Modified String: " + result);
    }

    static string CapitalizeFirstAndLastCharacter(string input)
    {
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (!string.IsNullOrWhiteSpace(words[i]))
            {
                char[] charArray = words[i].ToCharArray();

                // Capitalize the first character
                charArray[0] = char.ToUpper(charArray[0], CultureInfo.CurrentCulture);

                // Capitalize the last character
                charArray[charArray.Length - 1] = char.ToUpper(charArray[charArray.Length - 1], CultureInfo.CurrentCulture);

                words[i] = new string(charArray);
            }
        }

        return string.Join(" ", words);
    }
}