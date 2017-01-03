using System;
using System.Collections.Generic;
using System.Linq;

class CountSubstringOccurrences
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string keyWord = Console.ReadLine();

        int occurences = 0;
        int index = text.IndexOf(keyWord);
        while (index !=- 1)
        {
            occurences++;
            index = text.IndexOf(keyWord, index + 1);
        }

        Console.WriteLine(occurences);
    }
}
