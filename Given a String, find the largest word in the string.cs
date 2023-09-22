using System;

public class Program
{
    public static void Main()
    {
        string input = "This is a sample sentence with some long words";
        string largestWord = FindLargestWord(input);

        Console.WriteLine("Original String: " + input);
        Console.WriteLine("Largest Word: " + largestWord);
    }

    static string FindLargestWord(string input)
    {
        string[] words = input.Split(new[] { ' ', '\t', '\n', '\r', '.' }, StringSplitOptions.RemoveEmptyEntries);
        
        string largestWord = "";

        foreach (string word in words)
        {
            if (word.Length > largestWord.Length)
            {
                largestWord = word;
            }
        }
        return largestWord;
    }
}
