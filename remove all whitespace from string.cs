using System;
public class Program
{
     static void Main(string[] arg)
    {
        string str= "Hello   World!";
        string result = RemoveWhitespace(input);
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("String without Whitespace: " + result);
    }

    static string RemoveWhitespace(string input)
    {
        return str.Replace(" ", "");
    }
}