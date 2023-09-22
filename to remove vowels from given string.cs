using System;
public class Test
{
    static string remVowel(string str)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != 'a' && str[i] != 'A' && str[i] != 'e' && str[i] != 'E' && str[i] != 'i' && str[i] != 'I' && str[i] != 'o' && str[i] != 'O' && str[i] != 'u' && str[i] != 'U')
            {
                result += str[i];
            }
        }
        return result;
    }

static void Main(string[] arg)
    {
        string str = "hello";

        Console.Write(remVowel(str));
    }
}