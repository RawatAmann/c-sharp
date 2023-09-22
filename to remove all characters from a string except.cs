using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string input = "Hello, 123 World!";
        string result = RemoveNonAlphabeticCharacters(input);
        
        Console.WriteLine("Original String: " + input);
        Console.WriteLine("String with Only Alphabets: " + result);
    }

    static string RemoveNonAlphabeticCharacters(string input)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
