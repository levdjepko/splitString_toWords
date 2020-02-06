using System;

using System.Linq;


class MainClass
{

    public static string LongestWord(string inputString)
    {
        char[] separators = { ' ', '\'', '^', '&', '!' };
        string[] splittedByWords = inputString.Split(separators);
        var sorted = splittedByWords.OrderByDescending(n => n.Length);
       
        var longestWord = sorted.FirstOrDefault();

        return longestWord;

    }

    static void Main()
    {
          Console.WriteLine(LongestWord(Console.ReadLine()));
    }

}
