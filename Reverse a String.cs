using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string input = "Hello123World45!";
        string reversed = ReverseString(input);
        int sumOfNumbers = CalculateSumOfNumbers(input);

        Console.WriteLine("Original String: " + input);
        Console.WriteLine("Reversed String: " + reversed);
        Console.WriteLine("Sum of Numbers: " + sumOfNumbers);
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int CalculateSumOfNumbers(string input)
    {
        int sum = 0;
        bool inNumber = false;
        StringBuilder currentNumber = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                inNumber = true;
                currentNumber.Append(c);
            }
            else
            {
                if (inNumber)
                {
                    sum += int.Parse(currentNumber.ToString());
                    currentNumber.Clear();
                    inNumber = false;
                }
            }
        }

        if (inNumber)
        {
            sum += int.Parse(currentNumber.ToString());
        }

        return sum;
    }
}
